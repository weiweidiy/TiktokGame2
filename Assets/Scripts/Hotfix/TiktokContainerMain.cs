using Adic;
using Adic.Container;
using GameCommands;
using JFrame;
using JFrame.Common;
using TiktokModels;
using UnityEngine;

namespace Tiktok
{
    /// <summary>
    /// 负责注册容器
    /// </summary>
    public class TiktokContainerMain : ContextRoot
    {
        IInjectionContainer container;

        public override void SetupContainers()
        {
            container = AddContainer<InjectionContainer>(/*ResolutionMode.RETURN_NULL*/)
                           .RegisterExtension<UnityBindingContainerExtension>()
                           .RegisterExtension<EventCallerContainerExtension>()
                           .RegisterExtension<CommanderContainerExtension>();


            ////绑定通用工具类(无依赖)
            //container.Bind<PrefabLocation>().ToSingleton<PrefabLocation>();
            //container.Bind<WarriorAnimation>().ToSingleton<WarriorAnimation>();
            container.Bind<Utility>().ToSingleton<Utility>();
            container.Bind<EventManager>().ToSingleton<EventManager>();
            container.Bind<IAssetsLoader>().ToSingleton<YooAssetsLoader>();
            container.Bind<BaseClassPool>().ToSingleton<TiktokClassPool>();
            container.Bind<ITimerUtils>().ToSingleton<DotweenUtils>();

            ///依赖EventManager，BaseClassPool
            container.Bind<CommonEventManager>().ToSingleton<CommonEventManager>();

            ////绑定通用逻辑
            //container.Bind<GameObjectManager>().ToSingleton<MyGameObjectPool>();
            //container.Bind<ITransitionProvider>().ToSingleton<SMTransitionProvider>();



            ////绑定模型
            ///依赖CommonEventManager
            container.Bind<PlayerModel>().ToSingleton<PlayerModel>();
            //container.Bind<UserModel>().ToSingleton<UserModel>();
            //container.Bind<TeamModel>().ToSingleton<TeamModel>();
            //container.Bind<PowerModel>().ToSingleton<PowerModel>();
            //container.Bind<RankModel>().ToSingleton<RankModel>();
            //container.Bind<TeamScoreModel>().ToSingleton<TeamScoreModel>();


            ////绑定视图controller
            ///依赖IAssetsLoader
            container.Bind<IGameObjectPool>().ToSingleton<TiktokGameObjectPool>();
            ///依赖IAssetsLoader
            container.Bind<UIManager>().ToSingleton<UIManager>();

            //container.Bind<SceneSM>().ToSingleton<SceneSM>();
            //container.Bind<SceneController>().ToSingleton<SceneController>();
            //container.Bind<SceneTransitionController>().ToSingleton<SceneTransitionController>();
            //container.Bind<BackgroundController>().ToSingleton<BackgroundController>();
            //container.Bind<SlotsController>().ToSingleton<SlotsController>();
            //container.Bind<WarriorControllerManager>().ToSingleton<WarriorControllerManager>();
            //container.Bind<PlayerControllerManager>().ToSingleton<PlayerControllerManager>();


            //绑定系统
            container.Bind<TiktokSceneInitState>().ToSingleton<TiktokSceneInitState>();
            container.Bind<TiktokSceneMenuState>().ToSingleton<TiktokSceneMenuState>();
            container.Bind<TiktokSceneGameState>().ToSingleton<TiktokSceneGameState>();
            container.Bind<TiktokSceneSMContext>().ToSingleton<TiktokSceneSMContext>();
            container.Bind<TiktokSceneSM>().ToSingleton<TiktokSceneSM>();

            //container.Bind<BattleCalculator>().ToSingleton<BattleCalculator>();
            //container.Bind<BattleSystem>().ToSingleton<BattleSystem>();

            ////绑定命令
            container.RegisterCommands("GameCommands");
            //container.RegisterCommand<CommandStartupGame>();
            //container.RegisterCommand<CommandSwitchToBattleScene>();
            //container.RegisterCommand<CommandNextBattleState>();


        }

        public override void Init()
        {
            Debug.Log("Init");
            var dispatcher = container.GetCommandDispatcher();
            dispatcher.Dispatch<CommandStartupGame>();

        }

    }
}

