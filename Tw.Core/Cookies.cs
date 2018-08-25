using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Tw.Core
{
    public class Cookies:ICookies
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Cookies(IHttpContextAccessor _IHttpContextAccessor)
        {
            _httpContextAccessor = _IHttpContextAccessor;
        }

        public string GetCookies(string Key)
        {
            string Value = _httpContextAccessor.HttpContext.Request.Cookies[Key];
            return Value;
        }

        public void SetCookies(string Key, string Value)
        {
            CookieOptions option = new CookieOptions();
            _httpContextAccessor.HttpContext.Response.Cookies.Append(Key, Value, option);
        }
    }
}
