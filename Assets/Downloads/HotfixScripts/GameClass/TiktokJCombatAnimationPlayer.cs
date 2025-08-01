﻿using Adic;
using JFramework;
using JFramework.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace Tiktok
{
    public class TiktokJCombatAnimationPlayer : IJCombatAnimationPlayer
    {
        public event Action onExitClicked;

        [Inject]
        TiktokConfigManager jConfigManager;

        [Inject]
        protected TiktokGameObjectManager gameObjectManager;
        [Inject]
        protected GameLevelViewController gameLevelViewController;

        [Inject]
        protected LevelsModel levelsModel;

        [Inject]
        protected PlayerModel playerModel;

        TaskCompletionSource<bool> tcs = null;

        Dictionary<string, IAnimationPlayer> combatUnits = new Dictionary<string, IAnimationPlayer>();

        public TiktokJCombatAnimationPlayer()
        {
            Debug.Log("TiktokJCombatAnimationPlayer Constructor " + GetHashCode());
        }

        public Task Initialize<T>(JCombatTurnBasedReportData<T> reportData) where T : IJCombatUnitData
        {
            var report = reportData as TiktokJCombatTurnBasedReportData;
            this.tcs = tcs == null ? new TaskCompletionSource<bool>() : tcs;

            //创建战斗场景，战斗单位等
            var scenceBusinessId = report.CombatSceneBusinessId;
            var cfgData = jConfigManager.Get<CombatScenesCfgData>(scenceBusinessId);
            var prefabData = jConfigManager.Get<PrefabsCfgData>(cfgData.PrefabUid);
            var goCombat = gameObjectManager.Rent(prefabData.PrefabName);
            goCombat.transform.SetParent(gameLevelViewController.GetRoot());
            goCombat.transform.localPosition = Vector3.zero;
            var combatView = goCombat.GetComponent<TiktokCombatView>();
            combatView.onMaskClicked += CombatView_onMaskClicked;

            //创建战斗单位
            var playerUid = playerModel.GetPlayerUid();
            var playerFormation = report.FormationData[playerUid];
            InitFormationUnits(playerFormation, combatView);

            var levelNodeFormation = GetLevelNodeFormation(report.FormationData, playerUid);
            InitFormationUnits(levelNodeFormation, combatView,true);

            return Task.CompletedTask;
        }

        List<TiktokJCombatUnitData> GetLevelNodeFormation(Dictionary<string , List<TiktokJCombatUnitData>> data, string playerUid)
        {
            var keys = data.Keys;
            foreach (var key in keys)
            {
                if(key != playerUid)
                    return data[key];
            }
            return null;
        }

        void InitFormationUnits(List<TiktokJCombatUnitData> formationList, TiktokCombatView combatView, bool flipX = false)
        {
            foreach (var unitData in formationList)
            {
                var uid = unitData.Uid;
                var samuraiBusinessId = unitData.SamuraiBusinessId;
                var soldierBusinessId = unitData.SoldierBusinessId;
                var seat = unitData.Seat;
                var soldierCfgData = jConfigManager.Get<SoldiersCfgData>(soldierBusinessId);
                var soldierPrefabData = jConfigManager.Get<PrefabsCfgData>(soldierCfgData.PrefabUid);
                var goUnit = gameObjectManager.Rent(soldierPrefabData.PrefabName);
                var offset = flipX ? 9 : 0;
                goUnit.transform.SetParent(combatView.GetSeat(seat + offset));
                goUnit.transform.localPosition = Vector3.zero;
                var animationPlayer = goUnit.GetComponent<IAnimationPlayer>();
                if (flipX == true) animationPlayer.FlipX();
                combatUnits.Add(uid, animationPlayer);
            }
        }

        private void CombatView_onMaskClicked(TiktokCombatView obj)
        {
            onExitClicked?.Invoke();

            foreach (var animationPlayer in combatUnits.Values)
            {
                gameObjectManager.Return((animationPlayer as MonoBehaviour).gameObject);
            }

            obj.onMaskClicked -= CombatView_onMaskClicked;
            gameObjectManager.Return(obj.gameObject);          
        }

        public async Task PlayAcion(string casterUid, string actionUid, Dictionary<string, List<ActionEffectInfo>> effect)
        {
            if(effect.ContainsKey(CombatEventType.Damage.ToString()))
                combatUnits[casterUid].Play("PVP_Atk",false);

            Debug.Log($"PlayAcion casterUid: {casterUid}, actionUid: {actionUid}");
            await Task.Delay(1000); // 模拟动画播放延时
        }


    }
}

