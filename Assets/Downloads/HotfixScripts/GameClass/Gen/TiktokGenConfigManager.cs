﻿/*
* 此类由ConfigTools自动生成. 不要手动修改!
*/
using System.Collections;
using System.Collections.Generic;
using JFramework.Game;

namespace JFramework
{
    public partial class TiktokGenConfigManager : JConfigManager
    {
        public TiktokGenConfigManager(IConfigLoader loader, IDeserializer deserializer) : base(loader)
        {
          RegisterTable<ActionExecutorsTable, ActionExecutorsCfgData>(nameof(ActionExecutorsTable), deserializer);
          RegisterTable<ActionFindersTable, ActionFindersCfgData>(nameof(ActionFindersTable), deserializer);
          RegisterTable<ActionsTable, ActionsCfgData>(nameof(ActionsTable), deserializer);
          RegisterTable<ActionTriggersTable, ActionTriggersCfgData>(nameof(ActionTriggersTable), deserializer);
          RegisterTable<CombatScenesTable, CombatScenesCfgData>(nameof(CombatScenesTable), deserializer);
          RegisterTable<FormationsTable, FormationsCfgData>(nameof(FormationsTable), deserializer);
          RegisterTable<FormationUnitsTable, FormationUnitsCfgData>(nameof(FormationUnitsTable), deserializer);
          RegisterTable<LevelsTable, LevelsCfgData>(nameof(LevelsTable), deserializer);
          RegisterTable<LevelsNodesTable, LevelsNodesCfgData>(nameof(LevelsNodesTable), deserializer);
          RegisterTable<PrefabsTable, PrefabsCfgData>(nameof(PrefabsTable), deserializer);
          RegisterTable<SamuraiTable, SamuraiCfgData>(nameof(SamuraiTable), deserializer);
          RegisterTable<SoldiersTable, SoldiersCfgData>(nameof(SoldiersTable), deserializer);
        }
    }

}
