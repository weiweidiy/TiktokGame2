using JFramework.Game;


namespace Tiktok
{

    public class FightDTO 
    {
        public string LevelNodeBusinessId { get; set; }

        public JCombatTurnBasedReportData<TiktokJCombatUnitData> ReportData { get; set; }

        public LevelNodeDTO LevelNodeDTO { get; set; }


    }

    public class TiktokJCombatUnitData : IJCombatUnitData
    {
        public string Uid { get; set; }
        public int Seat { get; set; }
        public int SamuraiId { get; set; }
        public int SoldierId { get; set; } // 可能需要在其他地方使用
    }
}