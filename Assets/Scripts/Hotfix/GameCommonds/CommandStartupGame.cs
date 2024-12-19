using Adic;
using Adic.Container;
using Cysharp.Threading.Tasks;
using JFrame;
using Tiktok;
using UnityEngine;


namespace GameCommands
{


    /// <summary>
    /// ������Ϸ��ֻ������1��
    /// </summary>
    public class CommandStartupGame : Command
    {
        [Inject]
        IInjectionContainer container;

        [Inject]
        IAssetsLoader assetsLoader;

        /// <summary>
        /// ��ͨ������
        /// </summary>
        [Inject]
        BaseClassPool classPool;



        /// <summary>
        /// �����������ֻ��1��ʵ������״̬�ģ�
        /// </summary>
        public override bool singleton { get { return true; } }


        public async override void Execute(params object[] parameters)
        {
            Debug.Log("CommandStartupGame");

            CheckInject();

            this.Retain();

            InitializeTools(); //1��������Ϸ ֻ���ʼ��1��

            InitializeModels(); //1��������Ϸ ֻ���ʼ��1��

            await InitializeViewSM(); //1��������Ϸ ֻ���ʼ��1��

            this.Release();
        }

        /// <summary>
        /// ��ʼ������
        /// </summary>
        void InitializeTools()
        {
            classPool.Initialize();
        }

        /// <summary>
        /// ��ʼ��ģ��
        /// </summary>
        void InitializeModels()
        {

        }

        /// <summary>
        /// ��ʼ��
        /// </summary>
        /// <returns></returns>
        async UniTask InitializeViewSM()
        {
            //�л�����
            var sm = container.Resolve<TiktokSceneSM>();
            var context = container.Resolve<TiktokSceneSMContext>();
            context.sm = sm;
            sm.Initialize(context);
            await sm.SwitchToMenu();

            Debug.Log("InitializeViews");        
        }

        /// <summary>
        /// ���ע��
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        void CheckInject()
        {
            if (assetsLoader == null)
                throw new System.Exception(this.GetType().ToString() + " Inject IAssetsLoader failed!");

            if (classPool == null)
                throw new System.Exception(this.GetType().ToString() + " Inject BaseClassPool failed!");

        }
    }


}
