using JFramework;
using System;
using System.Collections.Generic;

namespace Tiktok
{
    public class TiktokClassRegister : ITypeRegister
    {
        int index;
        public Dictionary<int, Type> GetTypes()
        {
            var result = new Dictionary<int, Type>();

            result.Add(GetIndex(), typeof(LoginReq));
            result.Add(GetIndex(), typeof(LoginRes));
            result.Add(GetIndex(), typeof(FightReq));
            result.Add(GetIndex(), typeof(FightRes));
            result.Add(GetIndex(), typeof(LevelNodeUnlockedNtf));


            result.Add(GetIndex(), typeof(EventFight));
            result.Add(GetIndex(), typeof(EventLevelNodeUnlock));
            result.Add(GetIndex(), typeof(EventEnterLevel));
            result.Add(GetIndex(), typeof(EventExitLevel));
            result.Add(GetIndex(), typeof(EventSwitchLevel));
            return result;
        }

        int GetIndex()
        {
            return index++;
        }
    }

    public class EventFight : Event { }
    
}

