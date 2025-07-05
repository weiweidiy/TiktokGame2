using Adic;
using Cysharp.Threading.Tasks;
using JFramework;
using JFramework.Game;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;



namespace Tiktok
{

    public class FakeServer
    {
        INetworkMessageProcessStrate processStrate;

        LevelsManager levelsManager;

        IJConfigManager jConfigManager;

        IGameDataStore jDataStore;

        FakeNotifier clientNotifier;

        [Inject]
        public FakeServer([Inject("Server")]INetworkMessageProcessStrate processStrate, IJConfigManager configManager, IDataManager dataManager , LevelsManager levelManager)
        {
            this.processStrate = processStrate;
            this.jConfigManager = configManager;
            this.levelsManager = levelManager;

            //levelsManager = new LevelsManager(new CommonEventManager(new TiktokClassPool()));
            jDataStore = new JDataStore(dataManager);

            //Initialize();
        }

        [Inject]
        public async void Initialize(FakeNotifier clientNotifier)
        {
            this.clientNotifier = clientNotifier;
            //初始化游戏数据
            levelsManager.Initialize(await GetLevelDataFromDataBase());
        }



        public byte[] OnRevieveData(byte[] data)
        {
            //处理收到的消息
            var message = processStrate.ProcessComingMessage(data);
            switch (message.TypeId)
            {
                case (int)ProtocolType.LoginReq:
                    return OnLogin(message);

                case (int)ProtocolType.FightReq:
                    return OnFight(message);
                default:
                    throw new Exception("没有实现协议 " +message.TypeId);

            }
        }



        byte[] OnLogin(IJNetMessage message)
        {
            var response = new LoginRes()
            {
                Code = 0,
                Uid = message.Uid,
                LevelData = levelsManager.Data
            };



            return processStrate.ProcessOutMessage(response);
        }


        private byte[] OnFight(IJNetMessage message)
        {
            var fightReq = message as FightReq;
            var nodeUid = fightReq.LevelNodeUid;


            //检查是否解锁
 

            //to do: 模拟战斗
            var result = true;


            //根据战斗结果，解锁后续节点或关卡
            var nodeCfgData = jConfigManager.Get<LevelsNodesCfgData>(nodeUid);
            var nextNodeUid = nodeCfgData.NextUid;

            if (result)
            {
                //解锁
                levelsManager.UnlockNodes(nextNodeUid);
                //通知解锁
                UniTask.Run(() =>
                {
                    var ntf = new LevelNodeUnlockedNtf();
                    ntf.Uid = Guid.NewGuid().ToString();
                    ntf.LevelNodeUid = nextNodeUid;
                    var msgNtf = processStrate.ProcessOutMessage(ntf);
                    clientNotifier.Notify(msgNtf);
                }); 
            }


            var response = new FightRes()
            {
                Code = 0,
                Uid = message.Uid,
            };
            return processStrate.ProcessOutMessage(response);
        }

        async Task<LevelData> GetLevelDataFromDataBase()
        {
            //从存档里获取记录，如果没有就创建个默认的
            var levelData = await jDataStore.GetAsync<LevelData>(nameof(LevelData));

            if (levelData != null)
                return levelData;

            //没有数据，要创建默认数据
            levelData = new LevelData();
            levelData.CurLevelUid = "1";

            var dicLevelsData = new Dictionary<string, List<LevelNodeVO>>();
            levelData.LevelsData = dicLevelsData;
            var allNodes = jConfigManager.GetAll<LevelsNodesCfgData>();

            var curLevelUid = "";
            List<LevelNodeVO> nodes = null;

            foreach (var levelNode in allNodes)
            {
                var levelUid = levelNode.LevelUid;
                if (curLevelUid != levelUid)
                {
                    curLevelUid = levelNode.LevelUid;
                    nodes = new List<LevelNodeVO>();
                    dicLevelsData.Add(curLevelUid, nodes);
                }

                var vo = new LevelNodeVO();
                vo.uid = levelNode.Uid;
                vo.state = levelNode.Uid == "1" ? LevelState.Unlocked : LevelState.Locked;
                nodes.Add(vo);

            }

            await jDataStore.SaveAsync<LevelData>(nameof(LevelData), levelData);
            return levelData;
        }
    }
}

