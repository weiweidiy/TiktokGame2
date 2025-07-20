using Adic;
using Cysharp.Threading.Tasks;
using Game.Common;
using JFramework;
using JFramework.Game;
using JFramework.Game.View;
using MackySoft.XPool.Unity;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tiktok
{
    public class TiktokSceneGameState : TiktokSceneState
    {
        [Inject]
        IAssetsLoader _assetsLoader;
        protected override IAssetsLoader AssetsLoader => _assetsLoader;

        [Inject]
        UIManager uiManager;

        [Inject]
        TiktokGameObjectManager gameObjectManager;

        string sceneName = "SceneGame";

        [Inject]
        ParallelLauncher veiwControllers;

        /// <summary>
        /// 所有
        /// </summary>
        [Inject]
        GameLevelViewController gameLevelViewController;

        [Inject]
        GameLevelUIController gameLevelUIController;

        [Inject]
        GameLevelNodeViewController gameLevelNodeViewController;

        [Inject]
        GameLevelNodeBottomViewController gameLevelNodeBottomViewController;

        [Inject]
        GameLevelNodeStarViewController gameLevelNodeStarViewController;

        [Inject]
        IJConfigManager jConfigManager;

        protected override async UniTask OnEnter()
        {
            var scene = await SwitchScene(sceneName, SceneMode.Additive);

            //设置为活动场景
            SceneManager.SetActiveScene(scene);

            var root = new GameObject("root");
            gameObjectManager.GoRoot = root;
            //初始化ui管理器
            await uiManager.Initialize("UISceneGameSettings");


            //初始化所有视图控制器
            InitializeVeiwControllers();

            //显示UI
            ShowUI();

            //完成后，才会切换完成
            Debug.Log("SwitchToGame OnEnter done");
        }

        async void InitializeVeiwControllers()
        {
            //启动关卡视图控制器


            veiwControllers.Add(gameLevelViewController);
            veiwControllers.Add(gameLevelUIController);
            veiwControllers.Add(gameLevelNodeBottomViewController);
            veiwControllers.Add(gameLevelNodeViewController);
            veiwControllers.Add(gameLevelNodeStarViewController);
            await veiwControllers.Start(null);

            gameLevelViewController.EnterLevel("1");
        }

        void ShowUI()
        {
            //显示底部按钮栏
            uiManager.ShowPanel<UIPanelBottomProperties>(nameof(UIPanelBottom), null);
        }
    }
}
//显示角色
//var goRole = gameObjectManager.Rent("Role");
//goRole.transform.parent = root.transform;
//gameObjectManager.Return(goRole);