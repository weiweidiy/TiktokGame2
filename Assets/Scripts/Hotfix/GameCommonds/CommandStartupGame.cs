using Adic;
using Adic.Container;
using JFrame;
using UnityEngine;


namespace GameCommands
{


    /// <summary>
    /// 运行游戏
    /// </summary>
    public class CommandStartupGame : Command
    {
        [Inject]
        IInjectionContainer container;

        [Inject]
        IAssetsLoader assetsLoader;

        /// <summary>
        /// 设置这个命令只有1个实例（无状态的）
        /// </summary>
        public override bool singleton { get { return true; } }

        public async override void Execute(params object[] parameters)
        {
            Debug.Log("CommandStartupGame");
            this.Retain();
            //初始化数据模型
            //GameModels.Init()

            //切换场景
            var loader = container.Resolve<IAssetsLoader>();
            var scene = await loader.LoadSceneAsync("Game", SceneMode.Additive);

            //初始化视图
            //GameViews.Init()
            //UI管理器初始化

            this.Release();
        }
    }


}
