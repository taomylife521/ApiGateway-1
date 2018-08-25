using System;
using System.Collections.Generic;
using System.Text;
using Tw.Redis;
using Microsoft.AspNetCore.Http;

namespace Tw.Redis
{
    public class Global_Session_Var
    {
        public static void Set(string Key, string Attr, string Value)
        {
            new RedisAssembly(0).StringSet(Key + "_" + Attr, Value);
        }
        public static string Get(string Key, string Attr)
        {
            return new RedisAssembly(0).StringGet(Key + "_" + Attr);
        }
    }
}
