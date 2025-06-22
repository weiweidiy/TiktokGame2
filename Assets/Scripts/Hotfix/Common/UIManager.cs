﻿using Adic;
using Cysharp.Threading.Tasks;
using deVoid.UIFramework;
using JFramework.Common;
using JFramework.Package;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.Rendering.Universal;


namespace JFramework
{
    /// <summary>
    /// UI管理器
    /// </summary>
    public class UIManager
    {
        
        IAssetsLoader assetsLoader;

        /// <summary>
        /// ui框架实例
        /// </summary>
        UIFrame uiFrame;

        /// <summary>
        /// 注册的ui预制体
        /// </summary>
        UISettings uiSettings;


        [Inject]
        public UIManager(IAssetsLoader assetsLoader)
        {
            if (assetsLoader == null)
                throw new Exception(this.GetType().ToString() + " Inject IAssetsLoader failed!");

            this.assetsLoader = assetsLoader;
        }

        /// <summary>
        /// 初始化,根据场景初始化
        /// </summary>
        public async UniTask Initialize(string uiSettingName)
        {
            uiSettings = await assetsLoader.LoadAssetAsync<UISettings>(uiSettingName);
            uiFrame = uiSettings.CreateUIInstance();
            Camera.main.GetUniversalAdditionalCameraData().cameraStack.Add(uiFrame.UICamera);
        }

        /// <summary>
        /// 注册ui,预制体需要在uisetting里注册
        /// </summary>
        /// <param name="screenId"></param>
        /// <param name="controller"></param>
        /// <param name="screenTransform"></param>
        string CreateScreenFromUISettings(string screenId)
        {
            //需要新的实例
            var screen = GetScreen(screenId);
            if (screen == null)
                throw new System.Exception("ui没有注册，请在uisettings中注册ui预制体：" + screenId);

            //用新的screenid注册prefab
            var newScreenId = Guid.NewGuid().ToString();
            var screenInstance = GameObject.Instantiate(screen);
            var screenController = screenInstance.GetComponent<IUIScreenController>();
            if (screenController != null)
            {
                Debug.Log("---- RegisterScreen  --------- " + screen.name);
                uiFrame.RegisterScreen(newScreenId, screenController, screenInstance.transform);
                if (screenInstance.activeSelf)
                {
                    screenInstance.SetActive(false);
                }
                return newScreenId;
            }
            else
            {
                throw new System.Exception("[UIConfig] Screen doesn't contain a ScreenController! Skipping " + screen.name);
            }
        }

        /// <summary>
        /// 显示panel
        /// </summary>
        /// <param name="screenId"></param>
        public string ShowPanel(string screenId , bool asNew = false)
        {
            if (uiFrame.IsPanelOpen(screenId) && asNew)
            {
                var newScreenId = CreateScreenFromUISettings(screenId);
                uiFrame.ShowPanel(newScreenId);
                return newScreenId;
            }

            uiFrame.ShowPanel(screenId);
            return screenId;
        }

        /// <summary>
        /// 显示panel
        /// </summary>
        /// <typeparam name="TArg"></typeparam>
        /// <param name="screenId"></param>
        /// <param name="properties"></param>
        public string ShowPanel<TArg>(string screenId, TArg properties, bool asNew = false) where TArg : IPanelProperties
        {
            if (uiFrame.IsPanelOpen(screenId) && asNew)
            {
                var newScreenId = CreateScreenFromUISettings(screenId);
                uiFrame.ShowPanel(newScreenId, properties);
                return newScreenId;
            }

            uiFrame.ShowPanel(screenId, properties);
            return screenId;
        }

        /// <summary>
        /// 销毁一个ui(unregist)
        /// </summary>
        /// <param name="screenId"></param>
        public void DestroyPanel(string screenId)
        {

        }

        /// <summary>
        /// 关闭Panel
        /// </summary>
        /// <param name="screenId"></param>
        public void HidePanel(string screenId)
        {
            uiFrame.HidePanel(screenId);
        }

        public void OpenWindow(string screenId)
        {
            uiFrame.OpenWindow(screenId);
        }

        public void OpenWindow<TArg>(string screenId, TArg properties) where TArg : IWindowProperties
        {
            uiFrame.OpenWindow(screenId, properties);
        }

        public void CloseWindow(string screenId)
        {
            uiFrame.CloseWindow(screenId);
        }

        /// <summary>
        /// 获取注册的预制体
        /// </summary>
        /// <param name="screenId"></param>
        /// <returns></returns>
        GameObject GetScreen(string screenId)
        {
            return uiSettings.screensToRegister.Where(i => i.name == screenId).SingleOrDefault();
        }
    }
}
