using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

namespace Tw.Core
{
    public class SessionManage : ISessionManage
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _Session => _httpContextAccessor.HttpContext.Session;

        public SessionManage(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public virtual void SetValue(string Key,string Value)
        {
            _Session.SetString(Key, Value);
        }

        public virtual string GetValue(string Key)
        {
            string code = _Session.GetString(Key);
            return code;
        }
    }
}
