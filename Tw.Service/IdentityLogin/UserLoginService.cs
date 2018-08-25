using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Dapper.FastCrud;
using Tw.Entity.IdentityServer;
using Tw.Core;
using Tw.Redis;

namespace Tw.Service.IdentityLogin
{
    public class UserLoginService: IUserLoginService
    {
        public virtual UserLoginResult ValidateUser(APIUser User)
        {
            IDbConnection Conn = new SqlConnection(AppConfig.UnifiedConnectionString);
            string Sql = "SELECT * FROM APIUser WHERE UserName=@UserName AND Password=@Password";
            APIUser T = Conn.Query<APIUser>(Sql, new { UserName = User.UserName, Password = User.Password}).SingleOrDefault();
            if (T == null)
            {
                return UserLoginResult.WrongPassword;
            }
            else
            {
                return UserLoginResult.Successful;
            }
        }
    }
}
