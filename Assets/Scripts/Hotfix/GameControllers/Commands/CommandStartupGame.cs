using Adic;
using Adic.Container;
using Cysharp.Threading.Tasks;
using Game.Common;
using JFramework;
using JFramework.Game;
using System;
using Tiktok;
using UnityEngine;


namespace GameCommands
{

    /// <summary>
    /// ������Ϸ��ֻ������1��, ����ע����ɺ����
    /// </summary>
    public class CommandStartupGame : Command
    {
        [Inject]
        IInjectionContainer container;

        [Inject]
        IAssetsLoader assetsLoader;

        /// <summary>
        /// ��ͨ������
        /// </summary>
        [Inject]
        IObjectPool classPool;

        /// <summary>
        /// ��Ϸ�������������
        /// </summary>
        [Inject]
        TiktokGameObjectManager gameObjectManager;


        [Inject]
        IJConfigManager jConfigManager;

        [Inject]
        TiktokNetMessageController tiktokNetMessageController;

        [Inject]
        ParallelLauncher parallelLauncher;


        /// <summary>
        /// �����������ֻ��1��ʵ������״̬�ģ�
        /// </summary>
        public override bool singleton { get { return true; } }


        public async override void Execute(params object[] parameters)
        {
            Debug.Log("CommandStartupGame");

            CheckInject();

            this.Retain();

            InitializeTools(); //1��������Ϸ ֻ���ʼ��1��

            InitializeModels(); //1��������Ϸ ֻ���ʼ��1��

            await InitializeViews(); //1��������Ϸ ֻ���ʼ��1��

            this.Release();
        }

        /// <summary>
        /// ��ʼ������
        /// </summary>
        void InitializeTools()
        {
            //��ͨ�����س�ʼ����ע����
            (classPool as TiktokClassPool).Initialize();
        }

        /// <summary>
        /// ��ʼ��ģ�ͣ�һ���ò��ϣ����ݶ���Ҫ�ȵ�¼������ʼ��
        /// </summary>
        void InitializeModels()
        {

        }

        /// <summary>
        /// ��ʼ��
        /// </summary>
        /// <returns></returns>
        async UniTask InitializeViews()
        {
            Debug.Log("InitializeViews");
            //�л�����
            var sm = container.Resolve<TiktokSceneSM>();
            var context = container.Resolve<TiktokSceneSMContext>();
            context.sm = sm;
            sm.Initialize(context);

            //�������ñ�        
            await jConfigManager.PreloadAllAsync();
            //��ʼ����Ϸ���������
            await gameObjectManager.Initialize();

            parallelLauncher.Add(tiktokNetMessageController);
            parallelLauncher.Run(null);

            await sm.SwitchToMenu();                 
        }

        /// <summary>
        /// ���ע��
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        void CheckInject()
        {
            if (assetsLoader == null)
                throw new System.Exception(this.GetType().ToString() + " Inject IAssetsLoader failed!");

            if (classPool == null)
                throw new System.Exception(this.GetType().ToString() + " Inject BaseClassPool failed!");

        }
    }


}
