using Adic;
using Game.Common;
using JFramework;
using System;
using System.Collections.Generic;
using Tiktok;


namespace GameCommands
{
    public class CommandFight : Command
    {
        [Inject]
        TiktokUnityHttpRequest jNetwork;

        [Inject]
        IObjectPool classPool;

        [Inject]
        LevelsModel levelsModel;

        [Inject]
        EventManager eventManager;

        public override async void Execute(params object[] parameters)
        {
            this.Retain();

            var nodeUid = (string)parameters[0];

            var req = classPool.Rent<FightDTO>();
            req.LevelNodeBusinessId = nodeUid;
            // var response = await jNetwork.SendMessage<FightRes>(req);
            var result = await jNetwork.RequestFight(req);

            eventManager.Raise<EventStartCombat>(result);
            //levelsModel.UpdateNode(result.LevelNodeDTO);

            classPool.Return(req);

            //更新模型数据，通过模型更新发送消息给UI

            this.Release();
        }

    }


}
