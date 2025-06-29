using Game.Common;
using JFramework;
using System;
using System.Collections.Generic;

namespace Tiktok
{
    public class TiktokNetMessageRegister : INetMessageRegister
    {
        public Dictionary<int, Type> GetAllTables()
        {
            var tables = new Dictionary<int, Type>();

            tables.Add(2, typeof(LoginRes)); //只需要注册服务器返回的消息类型

            return tables;
        }
    }
}

