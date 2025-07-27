using Adic;
using Game.Common;
using JFramework;
using System;
using System.Threading.Tasks;
using UnityEngine;


namespace Tiktok
{
    public class CombatViewController : BaseGameController
    {
        [Inject]
        protected TiktokGameObjectManager gameObjectManager;
        [Inject]
        protected GameLevelViewController gameLevelViewController;
        [Inject]
        protected TiktokConfigManager jConfigManager;

        [Inject]
        protected LevelsModel levelsModel;

        FightDTO fightDTO = null;

        TiktokCombatPlayer combatPlayer;

        [Inject]
        public CombatViewController(EventManager eventManager, TiktokCombatPlayer combatPlayer) : base(eventManager)
        {
            this.combatPlayer = combatPlayer;
        }
        protected override void OnStart(RunableExtraData extraData)
        {
            base.OnStart(extraData);
            eventManager.AddListener<EventStartCombat>(OnCombatStart);
        }


        protected override void OnStop()
        {
            base.OnStop();
            eventManager.RemoveListener<EventStartCombat>(OnCombatStart);
        }


        private async void OnCombatStart(EventStartCombat e)
        {
            fightDTO = e.Body as FightDTO;
            combatPlayer.LoadReportData(fightDTO.ReportData);
            //var cfgData = jConfigManager.Get<LevelsNodesCfgData>(fightDTO.LevelNodeBusinessId);
            //var prefabData = jConfigManager.Get<PrefabsCfgData>(cfgData.ScenePrefabUid);
            //var goCombat = gameObjectManager.Rent(prefabData.PrefabName);
            //goCombat.transform.SetParent(gameLevelViewController.GetRoot());
            //goCombat.transform.localPosition = Vector3.zero;
            //var combatView = goCombat.GetComponent<TiktokCombatView>();
            //combatView.onMaskClicked += CombatView_onMaskClicked;

            await combatPlayer.Play();
        }

        private void CombatView_onMaskClicked(TiktokCombatView obj)
        {
            obj.onMaskClicked -= CombatView_onMaskClicked;
            gameObjectManager.Return(obj.gameObject);

            levelsModel.UpdateNode(fightDTO.LevelNodeDTO);
        }
    }
}
