using JFramework.Game;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Tiktok
{
    public class TiktokJCombatAnimationPlayer : IJCombatAnimationPlayer
    {
        public Task Initialize<T>(JCombatTurnBasedReportData<T> reportData) where T : IJCombatUnitData
        {
            //创建战斗场景，战斗单位等


            //var cfgData = jConfigManager.Get<LevelsNodesCfgData>(fightDTO.LevelNodeBusinessId);
            //var prefabData = jConfigManager.Get<PrefabsCfgData>(cfgData.ScenePrefabUid);
            //var goCombat = gameObjectManager.Rent(prefabData.PrefabName);
            //goCombat.transform.SetParent(gameLevelViewController.GetRoot());
            //goCombat.transform.localPosition = Vector3.zero;
            //var combatView = goCombat.GetComponent<TiktokCombatView>();
            //combatView.onMaskClicked += CombatView_onMaskClicked;


            return Task.CompletedTask;
        }

        public Task PlayAcion(string casterUid, string actionUid, Dictionary<string, List<ActionEffectInfo>> effect)
        {
            return Task.CompletedTask;
        }
    }
}

