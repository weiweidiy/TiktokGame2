using Adic;
using Game.Common;
using JFramework;
using System;
using Tiktok;


namespace GameCommands
{
    public class CommandFight : Command
    {
        [Inject]
        IJNetwork jNetwork;

        [Inject]
        IObjectPool classPool;

        public override async void Execute(params object[] parameters)
        {
            this.Retain();

            var nodeUid = (string)parameters[0];

            var req = classPool.Rent<FightReq>();
            req.Uid = Guid.NewGuid().ToString();
            req.LevelNodeUid = nodeUid;
            var response = await jNetwork.SendMessage<FightRes>(req);
            classPool.Return(req);
            this.Release();
        }
    }


}
