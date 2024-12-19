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
        /// 设置这个命令只有1个实例（无状态的）
        /// </summary>
        public override bool singleton { get { return true; } }


        public async override void Execute(params object[] parameters)
        {
            Debug.Log("CommandStartupGame");

            CheckInject();

            this.Retain();

            InitializeTools(); //1次启动游戏 只会初始化1次

            InitializeModels(); //1次启动游戏 只会初始化1次

            await InitializeViewSM(); //1次启动游戏 只会初始化1次

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
        /// 初始化
        /// </summary>
        /// <returns></returns>
        async UniTask InitializeViewSM()
        {
            //切换场景
            var sm = container.Resolve<TiktokSceneSM>();
            var context = container.Resolve<TiktokSceneSMContext>();
            context.sm = sm;
            sm.Initialize(context);
            await sm.SwitchToMenu();

            Debug.Log("InitializeViews");        
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

        }
    }


}
