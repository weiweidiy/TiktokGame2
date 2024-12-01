
using System;

namespace JFrame
{
    public abstract class BaseModel<TVo> : IUnique where TVo : struct
    {
        /// <summary>
        /// ֵ����,��������޸�ֵ
        /// </summary>
        protected TVo vo;
        public TVo VO => vo;

        /// <summary>
        /// Ψһid
        /// </summary>
        string uid;
        public string Uid => uid;

        /// <summary>
        /// ��Ϣϵͳ����������Ϣ�仯
        /// </summary>
        CommonEventManager eventManager;

        /// <summary>
        /// ��ʼ��ģ��
        /// </summary>
        /// <param name="vo"></param>
        public void Initialize(TVo vo)
        {
            this.vo = vo;
            uid = Guid.NewGuid().ToString();
        }


    }
}