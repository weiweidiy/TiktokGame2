using Adic;
using Cysharp.Threading.Tasks;
using JFrame;
using JFrame.Game.View;
using UnityEngine;
using UnityEngine.SceneManagement;
using YooAsset;

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

        protected override IAssetsLoader AssetsLoader => _assetsLoader;

        string sceneName = "SceneMenu";

        protected override async UniTask OnEnter()
        {
            CheckInject();

            var scene = await SwitchScene(sceneName, JFrame.SceneMode.Additive);


            //初始化ui管理器
            await uiManager.Initialize();

            //设置为活动场景
            SceneManager.SetActiveScene(scene);

            //初始化视图(场景，角色，UI等）
            //负责背景，角色，场景特效等 to do: 提前到startupcommand里？
            await gameObjectManager.Initialize();

            //显示menuUI
            var uiArg = new UIMenuPanelProperties();
            uiArg.onBtnEnterclick += UiArg_onBtnEnterclick; 
            uiManager.ShowPanel<UIMenuPanelProperties>("UIMenu", uiArg);
        }

        private void UiArg_onBtnEnterclick()
        {
            context.sm.SwitchToGame();
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
