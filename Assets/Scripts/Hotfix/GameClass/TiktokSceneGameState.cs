using Adic;
using Cysharp.Threading.Tasks;
using JFrame;

namespace Tiktok
{
    public class TiktokSceneGameState : TiktokSceneState
    {
        [Inject]
        IAssetsLoader _assetsLoader;
        protected override IAssetsLoader AssetsLoader => _assetsLoader;

        protected override async UniTask OnEnter()
        {
            await SwitchScene("SceneGame",SceneMode.Additive);
        }
    }
}
