using JFramework;
using JFramework.Package;

namespace Game.Common
{
    public class BaseViewController : BaseRunable
    {
        protected EventManager eventManager;

        public BaseViewController(EventManager eventManager)
        {
            this.eventManager = eventManager;
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arg"></param>
        protected void SendEvent<T>(object arg) where T : Event
        {
            var e = default(T);
            e.Body = arg;
            eventManager.Raise(e);
        }

    }
}
