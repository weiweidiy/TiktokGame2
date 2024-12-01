
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
        protected CommonEventManager eventManager;

        /// <summary>
        /// ��ʼ��ģ��
        /// </summary>
        /// <param name="vo"></param>
        public void Initialize(TData vo)
        {
            this.data = vo;
            uid = Guid.NewGuid().ToString();
        }


    }
}