using Adic;
using Cysharp.Threading.Tasks;
using JFramework;
using JFramework.Extern;
using JFramework.Game;
using JFramework.Game.View;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
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

        //[Inject]
        //IJNetwork jNetwork;

        [Inject]
        TiktokUnityHttpRequest httpRequest;

        [Inject]
        LevelsModel levelModel;

        [Inject]
        IJConfigManager jConfigManager;

        [Inject]
        IObjectPool classPool;

        protected override IAssetsLoader AssetsLoader => _assetsLoader;

        string sceneName = "SceneMenu";

        protected override async UniTask OnEnter()
        {
            CheckInject();

            //to do: 因为持久保留，要先清理，或者通过参数确定是否要重新初始化

            ////加载配置表        
            //await jConfigManager.PreloadAllAsync();
            ////初始化游戏对象管理器
            //await gameObjectManager.Initialize();


            //这个之前会持久保留，不会被销毁
            var scene = await SwitchScene(sceneName, JFramework.SceneMode.Additive);

            //设置为活动场景
            SceneManager.SetActiveScene(scene);


            //初始化ui管理器
            await uiManager.Initialize("UISceneMenuSettings");


            //显示menuUI
            var uiArg = new UIPanelMenuProperties();
            uiArg.onBtnEnterclick += UiArg_onBtnEnterclick;
            uiManager.ShowPanel(nameof(UIPanelMenu), uiArg);
        }

        private async void UiArg_onBtnEnterclick(UIPanelMenu controller)
        {
            //Debug.LogError("UiArg_onBtnEnterclick");
            var transition = await transitionProvider.InstantiateAsync(TransitionType.SMBlindsTransition.ToString());
            await transition.TransitionOut();

            // 发送POST请求（空body）
            var accountDTO = await httpRequest.RequestLogin( "jcw26");
            var gameDTO = await httpRequest.RequestEnterGame(accountDTO);
            //var str = Encoding.UTF8.GetString(result);


            //初始化必要模型
            levelModel.Initialize(gameDTO.LevelNodesDTO);


            await context.sm.SwitchToGame();
            Debug.Log("SwitchToGame done ");
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
