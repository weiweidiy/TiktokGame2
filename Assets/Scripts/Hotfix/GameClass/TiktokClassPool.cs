using JFramework;
using System;

namespace Tiktok
{
    public class TiktokClassPool : BaseClassPool
    {
        public override void Initialize()
        {
            Regist<LoginReq>();
            Regist<LoginRes>();
            Regist<FightReq>();
            Regist<FightRes>();
        }

        void RegistEvent<T>(Action<Event> onRent = null, Action<Event> onReturn = null, Action<Event> onRelease = null) where T : Event, new()
        {
            Regist<T>(onRent, onReturn, onRelease);
        }
    }

}

