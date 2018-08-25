using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tw.Entity.IdentityServer
{
    /// <summary>
    /// 实体类Tb_System_User 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class APIUser
    {
        public APIUser()
        { }
        #region Model
        private Guid _id;
        private string _username;
        private string _password;


        /// <summary>
        /// 
        /// </summary>
        public Guid Id
        {
            set { _id = value; }
            get { return _id; }
        }
        [Required(AllowEmptyStrings = false, ErrorMessage = "用户名是必填项")]
        [DisplayName("用户名")]
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "密码是必填项")]
        [DisplayName("密码")]
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }

        #endregion Model

    }
}

