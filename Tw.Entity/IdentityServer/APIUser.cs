using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tw.Entity.IdentityServer
{
    /// <summary>
    /// ʵ����Tb_System_User ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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
        [Required(AllowEmptyStrings = false, ErrorMessage = "�û����Ǳ�����")]
        [DisplayName("�û���")]
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "�����Ǳ�����")]
        [DisplayName("����")]
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }

        #endregion Model

    }
}

