using Adic;
using Cysharp.Threading.Tasks;
using JFramework;
using JFramework.Extern;
using JFramework.Game;
using JFramework.Game.View;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tiktok
{
    public class TiktokSceneMenuState : TiktokSceneState
    {
        [Inject]
        IAssetsLoader _assetsLoader;

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

        [Inject]
        ITransitionProvider transitionProvider;

        [Inject]
        JNetwork jNetwork;

        [Inject]
        LevelsModel levelModel;

        [Inject]
        IJConfigManager jConfigManager;

        protected override IAssetsLoader AssetsLoader => _assetsLoader;

        string sceneName = "SceneMenu";

        protected override async UniTask OnEnter()
        {
            CheckInject();

            //初始化游戏对象管理器
            await gameObjectManager.Initialize();

            var scene = await SwitchScene(sceneName, JFramework.SceneMode.Additive);

            //设置为活动场景
            SceneManager.SetActiveScene(scene);

            //初始化ui管理器
            await uiManager.Initialize("UISceneMenuSettings");

            //加载配置表
            jConfigManager.RegisterTable<LevelsCfg, LevelsData>(nameof(LevelsCfg), new LitJsonSerializer());
            await jConfigManager.PreloadAllAsync();

            //显示menuUI
            var uiArg = new UIPanelMenuProperties();
            uiArg.onBtnEnterclick += UiArg_onBtnEnterclick; 
            uiManager.ShowPanel<UIPanelMenuProperties>("UIMenu", uiArg);
        }

        private async void UiArg_onBtnEnterclick(UIPanelMenuController controller)
        {
            //Debug.LogError("UiArg_onBtnEnterclick");
            var transition = await transitionProvider.InstantiateAsync("SMBlindsTransition");
            await transition.TransitionOut();

            //链接服务器
            await jNetwork.Connect("");
            Debug.Log("链接成功");
            var c2sLogin = new C2S_Login();
            c2sLogin.Uid = Guid.NewGuid().ToString();
            c2sLogin.TypeId = 1;
            var loginData = await jNetwork.SendMessage<S2C_Login>(c2sLogin);


            //初始化必要模型
            levelModel.Initialize(loginData.LevelData.LevelsData);

            await context.sm.SwitchToGame();
            Debug.Log("SwitchToGame done " + loginData.Code);
            await transition.TransitionIn();
        }

        public override async UniTask OnExit()
        {
            AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync(sceneName);

            // 可选：等待卸载完成
            while (!asyncUnload.isDone)
            {
                await UniTask.Delay(100);
            }

            Debug.Log("Scene " + sceneName + " has been unloaded.");
            await base.OnExit();
        }

        void CheckInject()
        {
            if (gameObjectManager == null)
                throw new System.Exception(this.GetType().ToString() + " Inject TiktokGameObjectManager failed!");

            if (uiManager == null)
                throw new System.Exception(this.GetType().ToString() + " Inject UIManager failed!");
        }
    }
}
