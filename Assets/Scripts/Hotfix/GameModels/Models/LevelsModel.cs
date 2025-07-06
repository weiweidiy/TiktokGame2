using Adic;
using JFramework;
using JFramework.Game;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Tiktok
{
    public class LevelsModel : BaseModel<LevelData>
    {
        IJConfigManager jConfigManager;

        [Inject]
        public LevelsModel(EventManager eventManager, IJConfigManager jConfigManager) : base(eventManager)
        {
            this.jConfigManager = jConfigManager;
        }

        public string GetCurLevelUid()
        {
            return data.CurLevelUid;
        }

        public List<LevelNodeVO> GetLevelNodes(string levelUid)
        {
            var result = new List<LevelNodeVO>();

            foreach (var vo in data.LevelsData.Values)
            {
                var cfgData = jConfigManager.Get<LevelsNodesCfgData>(vo.uid);
                if (cfgData.LevelUid == levelUid)
                {
                    result.Add(vo);
                }
            }

            return result;
        }

        public async Task<List<string>> UnlockNodes(List<string> nodesUid)
        {
            var result = new List<string>();
            foreach (string nodeUid in nodesUid)
            {

                var success = UnlockNode(nodeUid);
                if (success) result.Add(nodeUid);
            }

            await OnUnlock(result);

            return result;
        }

        protected virtual Task OnUnlock(List<string> result)
        {
            //发消息，服务器可以是存档
            SendEvent<EventLevelNodeUnlock>(result);
            return Task.CompletedTask;
        }

        protected bool UnlockNode(string nodeUid)
        {
            if (nodeUid == "0")
                return false;

            var levelData = Data;

            //var cfgData = jConfigManager.Get<LevelsNodesCfgData>(nodeUid);
            var vo = Data.LevelsData[nodeUid];

            if (vo.state == LevelState.Unlocked) //已经解锁了，所以不用解锁了
                return false;

            vo.state = LevelState.Unlocked;
            Data.LevelsData[nodeUid] = vo;

            return true;
        }
    }

}
