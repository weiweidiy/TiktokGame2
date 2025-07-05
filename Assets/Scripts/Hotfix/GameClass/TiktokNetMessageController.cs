using Adic;
using Game.Common;
using JFramework;
using JFramework.Package;


namespace Tiktok
{
    /// <summary>
    /// 负责网络游戏消息转发
    /// </summary>
    public class TiktokNetMessageController : BaseGameController
    {
        [Inject]
        IJNetwork jNetwork;

        [Inject]
        public TiktokNetMessageController(EventManager eventManager) : base(eventManager)
        {
        }

        protected override void OnRun(RunableExtraData extraData)
        {
            base.OnRun(extraData);

            jNetwork.onMessage += JNetwork_onMessage;
        }



        protected override void OnStop()
        {
            base.OnStop();

            jNetwork.onMessage -= JNetwork_onMessage;
        }

        private void JNetwork_onMessage(IJNetMessage obj)
        {
           // throw new System.NotImplementedException();
        }
    }
}
