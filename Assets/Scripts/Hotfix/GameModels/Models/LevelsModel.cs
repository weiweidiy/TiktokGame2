using Adic;
using JFramework;
using JFramework.Game;
using System.Collections.Generic;


namespace Tiktok
{
    public class LevelsModel : BaseModel<LevelData>
    {
        

        [Inject]
        public LevelsModel(CommonEventManager eventManager) : base(eventManager)
        {
        }

        public string GetCurLevelUid()
        {
            return data.CurLevelUid;
        }

        public List<LevelNodeVO> GetLevelNodes(string levelUid)
        {
            return data.LevelsData[levelUid];
        }
    }

}
