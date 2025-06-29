using Adic;
using Adic.Container;
using GameCommands;
using Stateless;
using Tiktok;
using UnityEngine;
using JFramework;
using JFramework.Common;
using JFramework.Extern;
using Game.Common;
using JFramework.Package;
using JFramework.Game;


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


            ////绑定通用工具类(无依赖)~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //container.Bind<PrefabLocation>().ToSingleton<PrefabLocation>();
            //container.Bind<WarriorAnimation>().ToSingleton<WarriorAnimation>();
            container.Bind<Utility>().ToSingleton<Utility>();
            container.Bind<EventManager>().ToSingleton<EventManager>();
            container.Bind<IAssetsLoader>().ToSingleton<YooAssetsLoader>();
            container.Bind<BaseClassPool>().ToSingleton<TiktokClassPool>();
            container.Bind<ITimerUtils>().ToSingleton<DotweenUtils>();
            container.Bind<ITransitionProvider>().ToSingleton<SMTransitionProvider>();
            container.Bind<IConfigLoader>().ToSingleton<YooAssetsLoader>();
            container.Bind<IDataConverter>().ToSingleton<LitJsonSerializer>();
            container.Bind<IDeserializer>().ToSingleton<LitJsonSerializer>();

            //绑定配置表管理类 dependence : IConfigLoader,IDeserializer
            container.Bind<IJConfigManager>().ToSingleton<TiktokConfigManager>();

            //绑定存档管理器 dependence : IDataConverter
            container.Bind<IDataManager>().ToSingleton<UnityPrefDataManager>();

            //绑定网络类
            container.Bind<INetMessageRegister>().ToSingleton<TiktokNetMessageRegister>();
            container.Bind<IMessageTypeResolver>().ToSingleton<CommonJNetMessageTypeResolver>();
            container.Bind<INetMessageSerializerStrate>().ToSingleton<CommonJNetMessageJsonSerializerStrate>();
            container.Bind<INetworkMessageProcessStrate>().ToSingleton<CommonJNetworkMessageProcessStrate>();
            container.Bind<ISocketFactory>().ToSingleton<SocketFactory>();
            container.Bind<IJTaskCompletionSourceManager<IUnique>>().To<JTaskCompletionSourceManager<IUnique>>();
            container.Bind<IJNetwork>().ToSingleton<CommonJNetwork>();


            ///依赖EventManager，BaseClassPool
            container.Bind<CommonEventManager>().ToSingleton<CommonEventManager>();

            ////绑定通用逻辑
            //container.Bind<GameObjectManager>().ToSingleton<MyGameObjectPool>();
            //container.Bind<ITransitionProvider>().ToSingleton<SMTransitionProvider>();



            ////绑定模型~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ///依赖CommonEventManager
            container.Bind<LevelsModel>().ToSingleton<LevelsModel>();
            //container.Bind<UserModel>().ToSingleton<UserModel>();
            //container.Bind<TeamModel>().ToSingleton<TeamModel>();
            //container.Bind<PowerModel>().ToSingleton<PowerModel>();
            //container.Bind<RankModel>().ToSingleton<RankModel>();
            //container.Bind<TeamScoreModel>().ToSingleton<TeamScoreModel>();


            ////绑定视图controller~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ///依赖IAssetsLoader
            container.Bind<TiktokGameObjectPool>().ToSingleton<TiktokGameObjectPool>();
            container.Bind<TiktokGameObjectManager>().ToSingleton();
            ///依赖IAssetsLoader
            container.Bind<UIManager>().ToSingleton<UIManager>();

            //每次都是新的实例
            container.Bind<GameLevelViewController>().ToSingleton<GameLevelViewController>();
            container.Bind<GameLevelNodeViewController>().ToSingleton<GameLevelNodeViewController>();
            container.Bind<ParallelLauncher>().ToSelf();


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

