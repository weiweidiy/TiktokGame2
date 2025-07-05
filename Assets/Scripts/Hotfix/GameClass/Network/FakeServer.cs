using JFramework;
using JFramework.Game;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace Tiktok
{

    public class FakeServer
    {
        INetworkMessageProcessStrate processStrate;

        LevelsManager levelsManager;

        IJConfigManager jConfigManager;

        IGameDataStore jDataStore;

        public FakeServer(INetworkMessageProcessStrate processStrate, IJConfigManager configManager, IDataManager dataManager)
        {
            this.processStrate = processStrate;
            this.jConfigManager = configManager;

            levelsManager = new LevelsManager(new CommonEventManager(new TiktokClassPool()));
            jDataStore = new JDataStore(dataManager);

            Initialize();
        }
        public async void Initialize()
        {
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
                    return null;

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

            //to do: 模拟战斗

            //根据战斗结果，解锁后续节点或关卡
            var nodeCfgData = jConfigManager.Get<LevelsNodesCfgData>(nodeUid);
            var nextNodeUid = nodeCfgData.NextUid;

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

