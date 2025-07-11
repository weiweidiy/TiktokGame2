using JFramework;
using JFramework.Package;

namespace Game.Common
{
    /// <summary>
    /// 游戏控制器基类，游戏业务逻辑写在这里
    /// </summary>
    public class BaseGameController : BaseRunable
    {
        protected EventManager eventManager;

        public BaseGameController(EventManager eventManager)
        {
            this.eventManager = eventManager;

        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arg"></param>
        protected void SendEvent<T>(object arg) where T : Event, new() 
        {
            eventManager.Raise<T>(arg);
        }

    }
}
