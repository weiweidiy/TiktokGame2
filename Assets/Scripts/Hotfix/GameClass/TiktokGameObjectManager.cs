using Adic;
using Cysharp.Threading.Tasks;
using System;
using System.Threading.Tasks;

namespace Tiktok
{

    public class TiktokGameObjectManager
    {
        /// <summary>
        /// 游戏对象对象池
        /// </summary>
        TiktokGameObjectPool goPool;

        TiktokBackgroundController bgController;

        [Inject]
        public TiktokGameObjectManager(TiktokGameObjectPool goPool)
        {
            if (goPool == null)
                throw new Exception(this.GetType().ToString() + " Inject TiktokGameObjectPool failed!");

            this.goPool = goPool;
        }

        public async UniTask Initialize()
        {
            await goPool.Initialize();
        }
    }
}
