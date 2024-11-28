using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace JFrame
{
    public interface IAssetsLoader
    {
        UniTask<Scene> LoadSceneAsync(string sceneName);

        UniTask<GameObject> InstantiateAsync(string location);

        UniTask<GameObject> InstantiateAsync(string location, Transform parent);

        UniTask<T> LoadAssetAsync<T>(string location) where T : Object ;
    }
}

