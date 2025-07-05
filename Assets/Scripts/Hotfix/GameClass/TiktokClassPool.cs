using JFramework;
using System;

namespace Tiktok
{
    public class TiktokClassPool : BaseClassPool
    {
        public override void Initialize()
        {
            //注册网络协议对象
            Regist<LoginReq>();
            Regist<LoginRes>();
            Regist<FightReq>();
            Regist<FightRes>();
            Regist<LevelNodeUnlockedNtf>();


            //注册events
            RegistEvent<EventFight>();
            RegistEvent<EventLevelNodeUnlock>();
        }

        void RegistEvent<T>(Action<Event> onRent = null, Action<Event> onReturn = null, Action<Event> onRelease = null) where T : Event, new()
        {
            Regist<T>(onRent, onReturn, onRelease);
        }
    }

    /// <summary>
    /// 开始战斗
    /// </summary>
    public class EventFight : Event { }

    /// <summary>
    /// 关卡节点解锁了
    /// </summary>
    public class EventLevelNodeUnlock : Event { }
}

