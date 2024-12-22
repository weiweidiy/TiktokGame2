using Adic;
using Cysharp.Threading.Tasks;
using JFrame;
using JFrame.Game.View;
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

        string sceneName = "SceneGame";

        protected override async UniTask OnEnter()
        {
            var scene = await SwitchScene(sceneName, SceneMode.Additive);

            //设置为活动场景
            SceneManager.SetActiveScene(scene);

            await uiManager.Initialize("UISceneGameSettings");

            uiManager.ShowPanel<UIPanelBottomProperties>("UIPannelBottom", null);
        }
    }
}
