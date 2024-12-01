using Adic;
using Adic.Container;
using JFrame;
using UnityEngine;


namespace GameCommands
{


    /// <summary>
    /// ������Ϸ
    /// </summary>
    public class CommandStartupGame : Command
    {
        [Inject]
        IInjectionContainer container;

        [Inject]
        IAssetsLoader assetsLoader;

        /// <summary>
        /// �����������ֻ��1��ʵ������״̬�ģ�
        /// </summary>
        public override bool singleton { get { return true; } }

        public async override void Execute(params object[] parameters)
        {
            Debug.Log("CommandStartupGame");
            this.Retain();
            //��ʼ������ģ��
            //GameModels.Init()

            //�л�����
            var loader = container.Resolve<IAssetsLoader>();
            var scene = await loader.LoadSceneAsync("Game", SceneMode.Additive);

            //��ʼ����ͼ
            //GameViews.Init()
            //UI��������ʼ��

            this.Release();
        }
    }


}
