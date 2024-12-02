
using Adic;
using System;

namespace JFrame
{
    public abstract class BaseModel<TData> : IUnique
    {
        /// <summary>
        /// ֵ����,��������޸�ֵ
        /// </summary>
        protected TData data;
        public TData Data => data;

        /// <summary>
        /// Ψһid
        /// </summary>
        string uid;
        public string Uid => uid;

        /// <summary>
        /// ��Ϣϵͳ����������Ϣ�仯
        /// </summary>
        [Inject]
        protected CommonEventManager eventManager;

        /// <summary>
        /// ��ʼ��ģ��
        /// </summary>
        /// <param name="vo"></param>
        public void Initialize(TData vo)
        {
            this.data = vo;
            uid = Guid.NewGuid().ToString();

            if (eventManager == null)
                throw new Exception(this.GetType().ToString() + "inject eventManager failed, it is null !");
        }

        /// <summary>
        /// ������Ϣ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arg"></param>
        protected void SendEvent<T>(object arg) where T : Event
        {
            eventManager.SendEvent<T>(arg);
        }
    }
}