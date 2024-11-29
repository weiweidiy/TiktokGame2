using Adic;
using Cysharp.Threading.Tasks;
using JFrame;

public class TiktokGameObjectPool : BaseGameObjectPool
{
    [Inject]
    protected IAssetsLoader _assetsLoader;

    public override UniTask Initialize()
    {
        //to do:注册所有游戏对象
        throw new System.NotImplementedException();
    }

    protected override IAssetsLoader GetAssetLoader()
    {
        return _assetsLoader;
    }
}