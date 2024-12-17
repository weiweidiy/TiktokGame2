using Adic;
using Adic.Container;
using Cysharp.Threading.Tasks;
using JFrame;
using Tiktok;
using UnityEngine;


namespace GameCommands
{


    /// <summary>
    /// 运行游戏，只会运行1次
    /// </summary>
    public class CommandStartupGame : Command
    {
        [Inject]
        IInjectionContainer container;

        [Inject]
        IAssetsLoader assetsLoader;

        /// <summary>
        /// 普通类对象池
        /// </summary>
        [Inject]
        BaseClassPool classPool;

        /// <summary>
        /// 游戏场景对象管理器
        /// </summary>
        [Inject]
        TiktokGameObjectManager gameObjectManager;

        /// <summary>
        /// 游戏UI管理器
        /// </summary>
        [Inject]
        UIManager uiManager;

        /// <summary>
        /// 设置这个命令只有1个实例（无状态的）
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
        /// 初始化工具
        /// </summary>
        void InitializeTools()
        {
            classPool.Initialize();
        }

        /// <summary>
        /// 初始化模型
        /// </summary>
        void InitializeModels()
        {

        }

        /// <summary>
        /// 初始化视图
        /// </summary>
        /// <returns></returns>
        async UniTask InitializeViews()
        {
            //切换场景
            //var loader = container.Resolve<IAssetsLoader>();
            //var scene = await loader.LoadSceneAsync("Game", SceneMode.Additive);

            var sm = container.Resolve<TiktokSceneSM>();
            sm.Initialize(null);
            await sm.SwitchToMenu();
            await sm.SwitchToGame();

            Debug.Log("InitializeViews");

            //初始化视图(场景，角色，UI等）
            //负责背景，角色，场景特效等
            await gameObjectManager.Initialize();
            //ui
            await uiManager.Initialize();

            
        }

        /// <summary>
        /// 检查注入
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
