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

            result.Add(GetIndex(), typeof(LevelNodeDTO));
            result.Add(GetIndex(), typeof(FightDTO));


            result.Add(GetIndex(), typeof(EventFight));
            result.Add(GetIndex(), typeof(EventLevelNodeUpdate));
            result.Add(GetIndex(), typeof(EventEnterLevel));
            result.Add(GetIndex(), typeof(EventExitLevel));
            result.Add(GetIndex(), typeof(EventSwitchLevel));
            result.Add(GetIndex(), typeof(EventStartCombat));
            return result;
        }

        int GetIndex()
        {
            return index++;
        }
    }

    public class EventFight : Event { }
    
}

