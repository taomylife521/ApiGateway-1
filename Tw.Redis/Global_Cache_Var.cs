using System;
using System.Collections.Generic;
using System.Text;

namespace Tw.Redis
{
    public class Global_Cache_Var
    {
        public static void Set(string Key, string Value)
        {
            new RedisAssembly(0).StringSet(Key , Value);
        }
        public static string Get(string Key, string Attr)
        {
            return new RedisAssembly(0).StringGet(Key);
        }
    }
}
