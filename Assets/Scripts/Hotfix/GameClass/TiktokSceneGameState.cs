using Adic;
using Cysharp.Threading.Tasks;
using Game.Common;
using JFramework;
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

        protected override async UniTask OnEnter()
        {
            var scene = await SwitchScene(sceneName, SceneMode.Additive);

            //设置为活动场景
            SceneManager.SetActiveScene(scene);

            var root = new GameObject("root");
            //初始化ui管理器
            await uiManager.Initialize("UISceneGameSettings");

            //启动关卡视图控制器

            veiwControllers.Run(null);

            //显示角色
            var goRole = gameObjectManager.Rent("Role");
            goRole.transform.parent = root.transform;
            //gameObjectManager.Return(goRole);



            //显示ui
            uiManager.ShowPanel<UIPanelBottomProperties>("UIPannelBottom", null);


            //完成后，才会切换完成
            Debug.Log("SwitchToGame OnEnter done");
        }
    }
}
