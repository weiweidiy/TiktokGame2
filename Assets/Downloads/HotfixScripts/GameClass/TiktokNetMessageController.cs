//using Adic;
//using Game.Common;
//using JFramework;
//using System.Threading.Tasks;
//using UnityEngine;


//namespace Tiktok
//{
//    /// <summary>
//    /// 负责网络游戏消息转发
//    /// </summary>
//    public class TiktokNetMessageController : BaseGameController
//    {
//        [Inject]
//        IJNetwork jNetwork;

//        [Inject]
//        LevelsModel levelsModel;

//        [Inject]
//        public TiktokNetMessageController(EventManager eventManager) : base(eventManager)
//        {
//        }

//        protected override void OnStart(RunableExtraData extraData)
//        {
//            base.OnStart(extraData);

//            jNetwork.onMessage += JNetwork_onMessage;

//            //SetStartComplete();
//        }



//        protected override void OnStop()
//        {
//            base.OnStop();

//            jNetwork.onMessage -= JNetwork_onMessage;
//        }

//        private async void JNetwork_onMessage(IJNetMessage message)
//        {
//            switch ((ProtocolType)message.TypeId)
//            {
//                case ProtocolType.FightRes:
//                    {
//                        Debug.Log("收到 FightRes");

//                        SendEvent<EventFight>(message);
//                    }
//                    return;
//                case ProtocolType.LevelNodeUnlockedNtf:
//                    {
//                        Debug.Log("收到 LevelNodeUnlockedNtf");
//                        var msg = message as LevelNodeUnlockedNtf;
//                        await levelsModel.UnlockNodes(msg.LevelNodeUid);              
//                    }
//                    return ;

//                default: return;
//            }

//        }
//    }
//}
