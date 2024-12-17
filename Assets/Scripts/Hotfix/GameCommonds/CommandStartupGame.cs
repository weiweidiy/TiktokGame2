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
        /// ��Ϸ�������������
        /// </summary>
        [Inject]
        TiktokGameObjectManager gameObjectManager;

        /// <summary>
        /// ��ϷUI������
        /// </summary>
        [Inject]
        UIManager uiManager;

        /// <summary>
        /// �����������ֻ��1��ʵ������״̬�ģ�
        /// </summary>
        public override bool singleton { get { return true; } }


        public async override void Execute(params object[] parameters)
        {
            Debug.Log("CommandStartupGame");

            CheckInject();

            this.Retain();

            InitializeTools();

            InitializeModels();

            await InitializeViews();

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
        /// ��ʼ����ͼ
        /// </summary>
        /// <returns></returns>
        async UniTask InitializeViews()
        {
            //�л�����
            //var loader = container.Resolve<IAssetsLoader>();
            //var scene = await loader.LoadSceneAsync("Game", SceneMode.Additive);

            var sm = container.Resolve<TiktokSceneSM>();
            sm.Initialize(null);
            await sm.SwitchToMenu();
            await sm.SwitchToGame();

            Debug.Log("InitializeViews");

            //��ʼ����ͼ(��������ɫ��UI�ȣ�
            //���𱳾�����ɫ��������Ч��
            await gameObjectManager.Initialize();
            //ui
            await uiManager.Initialize();

            
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

            if (gameObjectManager == null)
                throw new System.Exception(this.GetType().ToString() + " Inject TiktokGameObjectManager failed!");

            if (uiManager == null)
                throw new System.Exception(this.GetType().ToString() + " Inject UIManager failed!");
        }
    }


}
