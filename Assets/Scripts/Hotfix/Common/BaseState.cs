using Cysharp.Threading.Tasks;
using System.Diagnostics;

namespace JFrame
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public abstract class BaseState<TContext>
    {
        /// <summary>
        /// 上下文
        /// </summary>
        protected TContext context;

        /// <summary>
        /// 状态机名字
        /// </summary>
        public string Name => GetType().Name;

        /// <summary>
        /// 状态进入时调用
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public virtual UniTask OnEnter(TContext context)
        {
            this.context = context;
            AddListeners();
            return UniTask.CompletedTask;
        }

        /// <summary>
        /// 状态退出时调用
        /// </summary>
        /// <returns></returns>
        public virtual UniTask OnExit()
        {
            RemoveListeners();
            return UniTask.CompletedTask;
        }

        /// <summary>
        /// 事件监听器，在状态进入时调用，子类重写
        /// </summary>
        public virtual void AddListeners() { }
        public virtual void RemoveListeners() { }
    }
}
