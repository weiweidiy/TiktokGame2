using Adic;

namespace JFramework
{
    /// <summary>
    /// 通用的事件中心
    /// </summary>
    public class CommonEventManager : EventManager
    {
        /// <summary>
        /// 普通类的对象池
        /// </summary>
        IObjectPool classPool;

        [Inject]
        public CommonEventManager(IObjectPool classPool) : base(classPool)
        {
            if (classPool == null)
                throw new System.Exception(this.GetType().ToString() + " Inject BaseClassPool failed !");

            this.classPool = classPool;
        }

        ///// <summary>
        ///// 发送消息
        ///// </summary>
        ///// <typeparam name="TEvent"></typeparam>
        ///// <param name="arg"></param>
        //public void SendEvent<TEvent>(object arg) where TEvent : JFramework.Event
        //{
        //    var obj = classPool.Rent<TEvent>();
        //    obj.Body = arg;
        //    Raise(obj);
        //    classPool.Return(obj);
        //}
    }
}