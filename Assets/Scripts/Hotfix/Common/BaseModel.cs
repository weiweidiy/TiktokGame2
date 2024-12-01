
using System;

namespace JFrame
{
    public abstract class BaseModel<TData> : IUnique
    {
        /// <summary>
        /// 值对象,子类可以修改值
        /// </summary>
        protected TData data;
        public TData Data => data;

        /// <summary>
        /// 唯一id
        /// </summary>
        string uid;
        public string Uid => uid;

        /// <summary>
        /// 消息系统，负责发送消息变化
        /// </summary>
        protected CommonEventManager eventManager;

        /// <summary>
        /// 初始化模型
        /// </summary>
        /// <param name="vo"></param>
        public void Initialize(TData vo)
        {
            this.data = vo;
            uid = Guid.NewGuid().ToString();
        }


    }
}