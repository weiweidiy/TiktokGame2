using Adic;
using Cysharp.Threading.Tasks;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Tiktok
{

    public class TiktokGameObjectManager
    {
        /// <summary>
        /// 游戏对象对象池
        /// </summary>
        TiktokGameObjectPool goPool;

        GameLevelViewController bgController;

        GameObject pools;

        [Inject]
        public TiktokGameObjectManager(TiktokGameObjectPool goPool)
        {
            if (goPool == null)
                throw new Exception(this.GetType().ToString() + " Inject TiktokGameObjectPool failed!");

            this.goPool = goPool;
        }

        public async UniTask Initialize()
        {
            pools = new GameObject("Pools");

            await goPool.Regist("Role", pools.transform,10, OnCreate, OnRelease, OnRent,OnReturn);
        }

        private void OnReturn(GameObject go)
        {
            go.SetActive(false);
            go.transform.parent = pools.transform;
        }

        private void OnRent(GameObject go)
        {
            go.SetActive(true);
        }

        /// <summary>
        /// 新的实例创建了
        /// </summary>
        /// <param name="go"></param>
        private void OnCreate(GameObject go)
        {
        }

        /// <summary>
        /// 实例是被释放掉了
        /// </summary>
        /// <param name="object"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void OnRelease(GameObject go)
        {
            GameObject.Destroy(go);
        }

        public GameObject Rent(string name)
        {
            return goPool.Rent(name);
        }

        public void Return(GameObject go)
        {
            goPool.Return(go);
        }

    }
}
