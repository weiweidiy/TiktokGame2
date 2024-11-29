using System;

namespace JFrame
{
    public class TiktokClassPool : BaseClassPool
    {
        public override void Initialize()
        {

        }

        void RegistEvent<T>(Action<Event> onRent = null, Action<Event> onReturn = null, Action<Event> onRelease = null) where T : Event, new()
        {
            Regist<T>(onRent, onReturn, onRelease);
        }
    }

}

