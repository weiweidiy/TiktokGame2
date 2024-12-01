
using System;

namespace JFrame
{
    public abstract class BaseModel<TVo> : IUnique where TVo : struct
    {
        /// <summary>
        /// 值对象,子类可以修改值
        /// </summary>
        protected TVo vo;
        public TVo VO => vo;

        /// <summary>
        /// 唯一id
        /// </summary>
        string uid;
        public string Uid => uid;

        /// <summary>
        /// 消息系统，负责发送消息变化
        /// </summary>
        CommonEventManager eventManager;

        /// <summary>
        /// 初始化模型
        /// </summary>
        /// <param name="vo"></param>
        public void Initialize(TVo vo)
        {
            this.vo = vo;
            uid = Guid.NewGuid().ToString();
        }


    }
}