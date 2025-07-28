using Adic;
using Adic.Container;
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
        IInjectionContainer container;
        [Inject]
        protected TiktokGameObjectManager gameObjectManager;
        [Inject]
        protected GameLevelViewController gameLevelViewController;
        [Inject]
        protected TiktokConfigManager jConfigManager;

        [Inject]
        protected LevelsModel levelsModel;

        FightDTO fightDTO = null;




        [Inject]
        public CombatViewController(EventManager eventManager) : base(eventManager)
        {
            
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

            var combatPlayer = container.Resolve<TiktokCombatPlayer>();

            combatPlayer.LoadReportData(fightDTO.ReportData);
            //var cfgData = jConfigManager.Get<LevelsNodesCfgData>(fightDTO.LevelNodeBusinessId);
            //var prefabData = jConfigManager.Get<PrefabsCfgData>(cfgData.ScenePrefabUid);
            //var goCombat = gameObjectManager.Rent(prefabData.PrefabName);
            //goCombat.transform.SetParent(gameLevelViewController.GetRoot());
            //goCombat.transform.localPosition = Vector3.zero;
            //var combatView = goCombat.GetComponent<TiktokCombatView>();
            //combatView.onMaskClicked += CombatView_onMaskClicked;

            await combatPlayer.Play();

            levelsModel.UpdateNode(fightDTO.LevelNodeDTO);
        }

        private void CombatView_onMaskClicked(TiktokCombatView obj)
        {
            obj.onMaskClicked -= CombatView_onMaskClicked;
            gameObjectManager.Return(obj.gameObject);

            levelsModel.UpdateNode(fightDTO.LevelNodeDTO);
        }
    }
}
