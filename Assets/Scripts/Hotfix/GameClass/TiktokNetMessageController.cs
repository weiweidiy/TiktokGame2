using Adic;
using Game.Common;
using JFramework;
using JFramework.Package;
using System.Net.Sockets;
using UnityEngine;


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
        public TiktokNetMessageController(EventManager eventManager, BaseClassPool classPool) : base(eventManager, classPool)
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

        private void JNetwork_onMessage(IJNetMessage message)
        {
            switch ((ProtocolType)message.TypeId)
            {
                case ProtocolType.FightRes:
                    {
                        Debug.Log("收到 FightRes");

                        SendEvent<EventFight>(message);
                    }
                    return;
                case ProtocolType.LevelNodeUnlockedNtf:
                    {
                        Debug.Log("收到 LevelNodeUnlockedNtf");
                        SendEvent<EventLevelNodeUnlock>(message);
                    }
                    return ;

                default: return;
            }

        }
    }
}
