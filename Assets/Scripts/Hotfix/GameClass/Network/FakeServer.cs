using JFramework;
using JFramework.Game;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tiktok;
using UnityEditor.Experimental.GraphView;


namespace Tiktok
{

    public class FakeServer
    {
        INetworkMessageProcessStrate processStrate;

        LevelsManager levelsManager;

        IJConfigManager configManager;

        IGameDataStore jDataStore;

        public FakeServer(INetworkMessageProcessStrate processStrate, IJConfigManager configManager, IDataManager dataManager)
        {
            this.processStrate = processStrate;
            this.configManager = configManager;

            levelsManager = new LevelsManager(new CommonEventManager(new TiktokClassPool()));
            jDataStore = new JDataStore(dataManager);

            Initialize();
        }


        public byte[] OnRevieveData(byte[] data)
        {
            //处理收到的消息
            var message = processStrate.ProcessComingMessage(data);
            if (message.TypeId == 1) //收到登录消息
            {
                return OnLogin(message);
            }

            return null;
        }


        byte[] OnLogin(IJNetMessage message)
        {
            var response = new S2C_Login() { Uid = message.Uid, TypeId = 2, Code = 1 };
            response.LevelData = levelsManager.Data;
            return processStrate.ProcessOutMessage(response);
        }


        public async void Initialize()
        {
            //初始化游戏数据
            levelsManager.Initialize(await GetLevelDataFromDataBase());
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
            var allNodes = configManager.GetAll<LevelsNodesCfgData>();

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

