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

        public IInjectionContainer Container { get { return container; } }

        public override void SetupContainers()
        {
            container = AddContainer<InjectionContainer>(/*ResolutionMode.RETURN_NULL*/)
                           .RegisterExtension<UnityBindingContainerExtension>()
                           .RegisterExtension<EventCallerContainerExtension>()
                           .RegisterExtension<CommanderContainerExtension>();


            ////绑定通用工具类(无依赖)~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //container.Bind<PrefabLocation>().ToSingleton<PrefabLocation>();
            //container.Bind<WarriorAnimation>().ToSingleton<WarriorAnimation>();
            container.Bind<Utility>().ToSingleton();
            
            container.Bind<IAssetsLoader>().ToSingleton<YooAssetsLoader>();
            container.Bind<ITypeRegister>().ToSingleton<TiktokClassRegister>();
            container.Bind<IObjectPool>().ToSingleton<CommonClassPool>();
            container.Bind<EventManager>().ToSingleton<CommonEventManager>();
            container.Bind<ITimerUtils>().ToSingleton<DotweenUtils>();
            container.Bind<ITransitionProvider>().ToSingleton<SMTransitionProvider>();
            container.Bind<IConfigLoader>().ToSingleton<YooAssetsLoader>();
            container.Bind<IDataConverter>().ToSingleton<LitJsonSerializer>();
            container.Bind<IDeserializer>().ToSingleton<LitJsonSerializer>();

            //绑定配置表管理类 dependence : IConfigLoader,IDeserializer
            container.Bind<IJConfigManager>().ToSingleton<TiktokGenConfigManager>();
            container.Bind<TiktokConfigManager>().ToSingleton();

            //绑定存档管理器 dependence : IDataConverter
            container.Bind<IDataManager>().ToSingleton<UnityPrefDataManager>();
            container.Bind<IGameDataStore>().ToSingleton<CommonDataStore>();

            //绑定网络类
            container.Bind<ITypeRegister>().ToSingleton<TiktokClientNetMessageRegister>().As("Client");
            container.Bind<IMessageTypeResolver>().ToSingleton<CommonClientJNetMessageTypeResolver>().As("Client");
            container.Bind<INetMessageSerializerStrate>().ToSingleton<CommonJNetMessageJsonSerializerStrate>();
            container.Bind<INetworkMessageProcessStrate>().ToSingleton<CommonClientJNetworkMessageProcessStrate>().As("Client");
            container.Bind<IJSocket>().To<FakeSocket>();
            container.Bind<ISocketFactory>().ToSingleton<SocketFactory>();
            container.Bind<IJTaskCompletionSourceManager<IUnique>>().To<JTaskCompletionSourceManager<IUnique>>();
            container.Bind<IJNetwork>().ToSingleton<CommonClientJNetwork>();


            ///依赖BaseClassPool
            //container.Bind<CommonEventManager>().ToSingleton();

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
            container.Bind<TiktokGameObjectPool>().ToSingleton();
            container.Bind<TiktokGameObjectManager>().ToSingleton();
            ///依赖IAssetsLoader
            container.Bind<UIManager>().ToSingleton();

            //消息处理
            container.Bind<TiktokNetMessageController>().ToSingleton();
            
            container.Bind<GameLevelViewController>().ToSingleton();
            container.Bind<GameLevelUIController>().ToSingleton();
            container.Bind<GameLevelNodeBottomViewController>().ToSingleton();
            container.Bind<GameLevelNodeViewController>().ToSingleton();
            //每次都是新的实例
            container.Bind<ParallelLauncher>().ToSelf();


            //container.Bind<SceneSM>().ToSingleton<SceneSM>();
            //container.Bind<SceneController>().ToSingleton<SceneController>();
            //container.Bind<SceneTransitionController>().ToSingleton<SceneTransitionController>();
            //container.Bind<BackgroundController>().ToSingleton<BackgroundController>();
            //container.Bind<SlotsController>().ToSingleton<SlotsController>();
            //container.Bind<WarriorControllerManager>().ToSingleton<WarriorControllerManager>();
            //container.Bind<PlayerControllerManager>().ToSingleton<PlayerControllerManager>();


            //绑定系统
            container.Bind<TiktokSceneInitState>().ToSingleton();
            container.Bind<TiktokSceneMenuState>().ToSingleton();
            container.Bind<TiktokSceneGameState>().ToSingleton();
            container.Bind<TiktokSceneSMContext>().ToSingleton();
            container.Bind<TiktokSceneSM>().ToSingleton();

            //container.Bind<BattleCalculator>().ToSingleton<BattleCalculator>();
            //container.Bind<BattleSystem>().ToSingleton<BattleSystem>();

            ////绑定命令
            container.RegisterCommands("GameCommands");
            //container.RegisterCommand<CommandStartupGame>();
            //container.RegisterCommand<CommandSwitchToBattleScene>();
            //container.RegisterCommand<CommandNextBattleState>();




            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 服务器相关 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            

            container.Bind<LevelsManager>().ToSingleton();
            container.Bind<ITypeRegister>().ToSingleton<TiktokServerNetMessageRegister>().As("Server");
            container.Bind<IMessageTypeResolver>().ToSingleton<CommonServerJNetMessageTypeResolver>().As("Server");
            container.Bind<INetworkMessageProcessStrate>().ToSingleton<CommonServerJNetworkMessageProcessStrate>().As("Server");
            container.Bind<FakeServer>().ToSingleton();         
            container.Bind<FakeNotifier>().ToSingleton();

        }

        public override void Init()
        {
            Debug.Log("Init");
            var dispatcher = container.GetCommandDispatcher();
            dispatcher.Dispatch<CommandStartupGame>();

        }

    }
}

