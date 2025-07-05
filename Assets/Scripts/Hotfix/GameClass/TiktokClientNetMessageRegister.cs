using Game.Common;
using JFramework;
using System;
using System.Collections.Generic;

namespace Tiktok
{
    public class TiktokClientNetMessageRegister : INetMessageRegister
    {
        public Dictionary<int, Type> GetAllTables()
        {
            var tables = new Dictionary<int, Type>();

            tables.Add((int)ProtocolType.LoginRes, typeof(LoginRes)); //只需要注册服务器返回的消息类型
            tables.Add((int)ProtocolType.FightRes, typeof(FightRes));
            tables.Add((int)ProtocolType.LevelNodeUnlockedNtf, typeof(LevelNodeUnlockedNtf));

            return tables;
        }
    }
}

