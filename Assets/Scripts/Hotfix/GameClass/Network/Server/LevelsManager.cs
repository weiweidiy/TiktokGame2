using Adic;
using JFramework;
using JFramework.Game;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Tiktok;
using UnityEngine;


namespace Tiktok
{
    public class LevelsManager : BaseModel<LevelData>
    {
        IJConfigManager jConfigManager;
       [Inject]
        public LevelsManager(CommonEventManager eventManager, IJConfigManager jConfigManager) : base(eventManager)
        {
            this.jConfigManager = jConfigManager;
        }

        public void UnlockNodes(List<string> nodesUid)
        {
            foreach (string nodeUid in nodesUid) {

                UnlockNode(nodeUid);
            }
        }

        void UnlockNode(string nodeUid)
        {
            var levelData = Data;

            var cfgData = jConfigManager.Get<LevelsNodesCfgData>(nodeUid);
            var key = cfgData.LevelUid;

            if (Data.LevelsData.TryGetValue(key, out List<LevelNodeVO> list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].uid == nodeUid)
                    {
                        LevelNodeVO node = list[i];
                        node.state = LevelState.Unlocked;
                        list[i] = node;
                        break;
                    }
                }
            }


        }

        public void UpdateStateByUid(List<LevelNodeVO> list, string uid, LevelState newState)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].uid == uid)
                {
                    LevelNodeVO node = list[i];
                    node.state = newState;
                    list[i] = node; // 必须重新赋值，因为结构体是值类型
                    break; // 如果只需要修改第一个匹配项
                }
            }
        }
    }
}

