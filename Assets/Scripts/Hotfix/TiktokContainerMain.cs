using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Adic;
using Adic.Container;
using System;
using JFrame.Common;
using YooAsset;
using MackySoft.XPool.Unity;
using Cysharp.Threading.Tasks;
using GameCommands;
using TiktokModels;

namespace JFrame.Game
{
    /// <summary>
    /// 负责注册容器
    /// </summary>
    public class TiktokContainerMain : ContextRoot
    {
        IInjectionContainer container;

        public override void SetupContainers()
        {
            container = AddContainer<InjectionContainer>()
                           .RegisterExtension<UnityBindingContainerExtension>()
                           .RegisterExtension<EventCallerContainerExtension>()
                           .RegisterExtension<CommanderContainerExtension>();


            ////绑定通用工具类(无依赖)
            //container.Bind<PrefabLocation>().ToSingleton<PrefabLocation>();
            //container.Bind<WarriorAnimation>().ToSingleton<WarriorAnimation>();
            container.Bind<Utility>().ToSingleton<Utility>();
            container.Bind<EventManager>().ToSingleton<EventManager>();
            container.Bind<IAssetsLoader>().ToSingleton<YooAssetsLoader>();
            container.Bind<IGameObjectPool>().ToSingleton<TiktokGameObjectPool>();
            container.Bind<BaseClassPool>().ToSingleton<TiktokClassPool>();
            container.Bind<ITimerUtils>().ToSingleton<DotweenUtils>();
            container.Bind<CommonEventManager>().ToSingleton<CommonEventManager>();

            ////绑定通用逻辑（有依赖)
            //container.Bind<GameObjectManager>().ToSingleton<MyGameObjectPool>();
            //container.Bind<ITransitionProvider>().ToSingleton<SMTransitionProvider>();
            //container.Bind<UIManager>().ToSingleton<UIManager>();

            ////绑定模型
            container.Bind<PlayerModel>().ToSingleton<PlayerModel>();
            //container.Bind<UserModel>().ToSingleton<UserModel>();
            //container.Bind<TeamModel>().ToSingleton<TeamModel>();
            //container.Bind<PowerModel>().ToSingleton<PowerModel>();
            //container.Bind<RankModel>().ToSingleton<RankModel>();
            //container.Bind<TeamScoreModel>().ToSingleton<TeamScoreModel>();


            ////绑定视图controller
            //container.Bind<SceneSM>().ToSingleton<SceneSM>();
            //container.Bind<SceneController>().ToSingleton<SceneController>();
            //container.Bind<SceneTransitionController>().ToSingleton<SceneTransitionController>();
            //container.Bind<BackgroundController>().ToSingleton<BackgroundController>();
            //container.Bind<SlotsController>().ToSingleton<SlotsController>();
            //container.Bind<WarriorControllerManager>().ToSingleton<WarriorControllerManager>();
            //container.Bind<PlayerControllerManager>().ToSingleton<PlayerControllerManager>();


            ////绑定系统
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

