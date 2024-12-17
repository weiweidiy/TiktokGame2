using Adic;
using Cysharp.Threading.Tasks;
using JFrame;

namespace Tiktok
{
    public class TiktokSceneMenuState : TiktokSceneState
    {
        [Inject]
        IAssetsLoader _assetsLoader;
        protected override IAssetsLoader AssetsLoader => _assetsLoader;

        protected override async UniTask OnEnter()
        {
            var scene = await SwitchScene("Menu", JFrame.SceneMode.Additive);
        }
    }
}
