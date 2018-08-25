using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Dapper.FastCrud;

namespace Tw.Repository
{
    public class Repository<Entity> : IRepository<Entity>
    {
        private string _Connection = "";
        public Repository(string __Connection)
        {
            _Connection = __Connection;
        }
        /// <summary>
        /// 得到一个实体
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Entity GetEntity(string Id)
        {
            IDbConnection _Dap = new SqlConnection(_Connection);
            string Query = "SELECT * FROM ["+ typeof(Entity).Name.ToString()+"] WHERE Id =@Id";
            Entity Entity = _Dap.Query<Entity>(Query, new { Id = Id }).SingleOrDefault();
            return Entity;
        } 
        /// <summary>
        /// 插入实体数据
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(Entity _Entity)
        {
            IDbConnection _Dap = new SqlConnection(_Connection);
            _Dap.Insert(_Entity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Update(Entity _Entity)
        {
            IDbConnection _Dap = new SqlConnection(_Connection);
            _Dap.Update(_Entity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(string Id)
        {
            IDbConnection _Dap = new SqlConnection(_Connection);
            string Query = "DELETE FROM [" + typeof(Entity).Name.ToString() + "] WHERE Id =@Id";
            _Dap.Execute(Query, new { Id = Id});
        }
    }
}
