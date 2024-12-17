using Adic;
using Cysharp.Threading.Tasks;
using JFrame;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tiktok
{
    public abstract class TiktokSceneState : BaseState<TiktokSceneSMContext>
    {
        protected abstract IAssetsLoader AssetsLoader { get; }

        protected UniTask<Scene> SwitchScene(string sceneName, SceneMode sceneMode)
        {
             return AssetsLoader.LoadSceneAsync(sceneName, sceneMode);
        }

  
    }
}
