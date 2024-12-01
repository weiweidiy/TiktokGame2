using Adic;

namespace JFrame
{
    /// <summary>
    /// 通用的事件中心
    /// </summary>
    public class CommonEventManager : EventManager
    {
        /// <summary>
        /// 普通类的对象池
        /// </summary>
        [Inject]
        BaseClassPool classPool;

        /// <summary>
        /// 消息系统，负责发送消息变化
        /// </summary>
        [Inject]
        EventManager eventManager;

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="arg"></param>
        protected void SendEvent<TEvent>(object arg) where TEvent : JFrame.Event
        {
            var obj = classPool.Rent<TEvent>();
            obj.Body = arg;
            this.eventManager.Raise(obj);
            classPool.Return(obj);
        }
    }
}