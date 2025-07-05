using Adic;
using JFramework;
using JFramework.Game;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiktok;
using UnityEngine;


namespace Tiktok
{
    public class LevelsManager : BaseModel<LevelData>
    {
        IJConfigManager jConfigManager;

        IGameDataStore dataStore;

       [Inject]
        public LevelsManager(CommonEventManager eventManager, IJConfigManager jConfigManager, IGameDataStore dataStore) : base(eventManager)
        {
            this.jConfigManager = jConfigManager;
            this.dataStore = dataStore;
        }

        public async Task<List<string>> UnlockNodes(List<string> nodesUid)
        {
            var result = new List<string>();
            foreach (string nodeUid in nodesUid) {

                var success = UnlockNode(nodeUid);
                if (success) result.Add(nodeUid);
            }

            if (result.Count > 0)
                await dataStore.SaveAsync(nameof(LevelData), Data);

            return result;
        }

        bool UnlockNode(string nodeUid)
        {
            if (nodeUid == "0")
                return false;

            var levelData = Data;

            var cfgData = jConfigManager.Get<LevelsNodesCfgData>(nodeUid);
            var vo = Data.LevelsData[nodeUid];

            if (vo.state == LevelState.Unlocked) //已经解锁了，所以不用解锁了
                return false;

            vo.state = LevelState.Unlocked;
            Data.LevelsData[nodeUid] = vo;

            return true;
        }
    }
}

