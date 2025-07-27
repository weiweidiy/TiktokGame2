using JFramework.Game;
using System.Collections.Generic;


namespace Tiktok
{

    public class FightDTO 
    {
        public string LevelNodeBusinessId { get; set; }

        public TiktokJCombatTurnBasedReportData ReportData { get; set; }

        public LevelNodeDTO LevelNodeDTO { get; set; }


    }

    public class TiktokJCombatTurnBasedReportData : JCombatTurnBasedReportData<TiktokJCombatUnitData>
    {
        public string CombatSceneBusinessId { get; set; } // 可能需要在其他地方使用
    }

    public class TiktokJCombatUnitData : IJCombatUnitData
    {
        public string Uid { get; set; }
        public int Seat { get; set; }
        public string SamuraiBusinessId { get; set; }
        public string SoldierBusinessId { get; set; } // 可能需要在其他地方使用
        public List<KeyValuePair<string, string>> Actions { get; set; }
    }
}