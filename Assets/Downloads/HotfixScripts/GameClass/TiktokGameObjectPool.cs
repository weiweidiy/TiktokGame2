using Adic;
using Cysharp.Threading.Tasks;
using Game.Common;
using JFramework;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Tiktok
{
    public class TiktokGameObjectPool : BaseGameObjectPool
    {
        [Inject]
        protected IAssetsLoader _assetsLoader;

        //public override UniTask Initialize()
        //{
        //    if (_assetsLoader == null)
        //        throw new System.Exception(this.GetType().ToString() + " Inject IAssetsLoader failed");

        //    //to do:注册所有游戏对象

        //    return UniTask.CompletedTask;
        //}

        protected override IAssetsLoader GetAssetLoader()
        {
            return _assetsLoader;
        }

    }
}
