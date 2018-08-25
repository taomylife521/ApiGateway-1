using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tw.Entity.IdentityServer;

namespace Tw.Service.IdentityLogin
{
    public partial interface IUserLoginService
    {
        /// <summary>
        /// Validate customer
        /// </summary>
        /// <param name="User">登录用户</param>
        /// <returns>LogResults</returns>
        UserLoginResult ValidateUser(APIUser User);
    }
}
