using Adic;
using Cysharp.Threading.Tasks;
using JFramework;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tiktok
{
    public abstract class TiktokSceneState : BaseStateAsync<TiktokSceneSMContext>
    {
        protected abstract IAssetsLoader AssetsLoader { get; }

        protected UniTask<Scene> SwitchScene(string sceneName, SceneMode sceneMode)
        {
             return AssetsLoader.LoadSceneAsync(sceneName, sceneMode);
        }

  
    }
}
