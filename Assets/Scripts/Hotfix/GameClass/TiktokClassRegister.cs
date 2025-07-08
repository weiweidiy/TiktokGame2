using JFramework;
using System;
using System.Collections.Generic;

namespace Tiktok
{
    public class TiktokClassRegister : ITypeRegister
    {
        public Dictionary<int, Type> GetTypes()
        {
            var result = new Dictionary<int, Type>();

            result.Add(0, typeof(LoginReq));
            result.Add(1, typeof(LoginRes));
            result.Add(2, typeof(FightReq));
            result.Add(3, typeof(FightRes));
            result.Add(4, typeof(LevelNodeUnlockedNtf));
            result.Add(5, typeof(EventFight));
            result.Add(6, typeof(EventLevelNodeUnlock));
            return result;
        }
    }
}

