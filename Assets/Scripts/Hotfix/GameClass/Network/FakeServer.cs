using JFramework;
using System.Collections.Generic;
using Tiktok;


namespace Tiktok
{

    public class FakeServer
    {
        INetworkMessageProcessStrate processStrate;

        LevelManager levelManager;

        public FakeServer(INetworkMessageProcessStrate processStrate)
        {
            this.processStrate = processStrate;

            levelManager = new LevelManager(new CommonEventManager(new TiktokClassPool()));

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
            response.LevelData = new LevelData() { CurLevel = 1 , LevelsData = levelManager.Data};
            return processStrate.ProcessOutMessage(response);
        }


        public void Initialize()
        {
            //初始化游戏数据
            levelManager.Initialize(GetLevelData());
        }


        List<LevelVO> GetLevelData()
        {
            var list = new List<LevelVO>();

            //假数据，真是从数据库获取
            var vo = new LevelVO();
            vo.id = 1;
            vo.state = LevelState.Locked;
            list.Add(vo);

            var vo2 = new LevelVO();
            vo2.id = 2;
            vo2.state = LevelState.Locked;
            list.Add(vo2);

            return list;
        }
    }
}

