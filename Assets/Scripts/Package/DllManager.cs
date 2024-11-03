﻿using Cysharp.Threading.Tasks;
using HybridCLR;
using System.Collections.Generic;
using UnityEngine;
using YooAsset;

namespace JFrame.Game.Package
{
    public class DllManager
    {
        List<string> AOTMetaAssemblyNames { get; } = new List<string>()
        {
            //"Assembly-CSharp.dll"
            //"mscorlib.dll",
            //"System.dll",
            //"System.Core.dll",
            //"DOTween.dll",
            //"DOTweenPro.dll",
            //"UniTask.dll",
            //"UniTask.DOTween.dll",
            //"UniTask.TextMeshPro.dll",
            //"UniTask.YooAsset.dll",
            //"YooAsset.dll",
            //"UnityEngine.dll",
            //"UnityEngine.CoreModule.dll",
        };

        public async UniTask LoadDLL()
        {

            try
            {
                // 可以加载任意aot assembly的对应的dll。但要求dll必须与unity build过程中生成的裁剪后的dll一致，而不能直接使用原始dll。
                // 我们在BuildProcessors里添加了处理代码，这些裁剪后的dll在打包时自动被复制到 {项目目录}/HybridCLRData/AssembliesPostIl2CppStrip/{Target} 目录。

                // 注意，补充元数据是给AOT dll补充元数据，而不是给热更新dll补充元数据。
                // 热更新dll不缺元数据，不需要补充，如果调用LoadMetadataForAOTAssembly会返回错误
                HomologousImageMode mode = HomologousImageMode.SuperSet;
                foreach (var assemblyName in AOTMetaAssemblyNames)
                {
                    var _Load = YooAssets.LoadAssetAsync<TextAsset>(assemblyName);
                    await _Load.ToUniTask();
                    var _Data = _Load.AssetObject as TextAsset;
                    // 加载assembly对应的dll，会自动为它hook。一旦aot泛型函数的native函数不存在，用解释器版本代码
                    LoadImageErrorCode err = RuntimeApi.LoadMetadataForAOTAssembly(_Data.bytes, mode);
                    Debug.Log($"LoadMetadataForAOTAssembly:{assemblyName}. mode:{mode} ret:{err}");
                    _Load.Release();
                }

                Debug.Log("AOT Done");

                //加载热更DLL
                var _LoadDLL = YooAssets.LoadAssetAsync<TextAsset>("Assembly-CSharp.dll");
                await _LoadDLL.ToUniTask();
                var _DLLData = _LoadDLL.AssetObject as TextAsset;
                System.Reflection.Assembly.Load(_DLLData.bytes);

                Debug.Log("Load Assembly-CSharp.dll Done");


            }
            catch
            {
                //PatchEventDispatcher.SendLoadDllError("应用程序已更新，请重新启动应用");
                Debug.LogError("应用程序已更新, 无法热重载");
            }

            // 完成
        }

    }
}