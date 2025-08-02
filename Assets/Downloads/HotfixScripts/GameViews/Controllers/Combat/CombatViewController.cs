using Adic;
using Adic.Container;
using Game.Common;
using JFramework;
using JFramework.Game;
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

        TiktokCombatPlayer combatPlayer;


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

            combatPlayer = container.Resolve<TiktokCombatPlayer>();

            combatPlayer.LoadReportData(fightDTO.ReportData);
            await combatPlayer.Play();

            Debug.LogError("播放完成了");
            levelsModel.UpdateNode(fightDTO.LevelNodeDTO);
        }

        //private void CombatView_onMaskClicked(TiktokCombatView obj)
        //{
        //    combatPlayer.Stop();

        //    obj.onMaskClicked -= CombatView_onMaskClicked;
        //    gameObjectManager.Return(obj.gameObject);

        //    levelsModel.UpdateNode(fightDTO.LevelNodeDTO);
        //}
    }
}
