using Adic;
using JFramework;
using JFramework.Game;
using System.Collections.Generic;


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
    }

}
