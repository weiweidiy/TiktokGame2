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
        public LevelsManager(CommonEventManager eventManager) : base(eventManager)
        {
        }

        public void UnlockNode(string nodeUid)
        {
            var levelData = Data;
            var allNodes = levelData.LevelsData.Values.ToList();
            
        }
    }
}

