using JFramework;
using JFramework.Game;
using System.Collections.Generic;
using Tiktok;


namespace Tiktok
{

    public class FakeServer
    {
        INetworkMessageProcessStrate processStrate;

        LevelsManager levelsManager;

        IJConfigManager configManager;

        JDataStore jDataStore;

        public FakeServer(INetworkMessageProcessStrate processStrate, IJConfigManager configManager)
        {
            this.processStrate = processStrate;
            this.configManager = configManager;

            levelsManager = new LevelsManager(new CommonEventManager(new TiktokClassPool()));
            //jDataStore = new JDataStore()

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


        public void Initialize()
        {
            //初始化游戏数据
            levelsManager.Initialize(GetLevelDataFromDataBase());
        }


        LevelData GetLevelDataFromDataBase()
        {
            var levelData = new LevelData();
            levelData.CurLevelUid = "1";

            var dicLevelsData = new Dictionary<string, List<LevelNodeVO>>();
            levelData.LevelsData = dicLevelsData;


            var allNodes =  configManager.GetAll<LevelsNodesCfgData>();

            //假数据，真是从数据库获取
            List<LevelNodeVO> nodes = new List<LevelNodeVO>();
            var vo = new LevelNodeVO();
            vo.uid = "1";
            vo.state = LevelState.Locked;
            nodes.Add(vo);
            dicLevelsData.Add("1", nodes);



            return levelData;
        }
    }
}

