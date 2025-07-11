using Adic;
using Game.Common;
using JFramework;
using JFramework.Game.View;
using JFramework.Package;
using UnityEngine;



namespace Tiktok
{
    public class GameLevelUIController : BaseGameController
    {
        [Inject]
        UIManager uiManager;
        public GameLevelUIController(EventManager eventManager) : base(eventManager)
        {
        }

        protected override void OnRun(RunableExtraData extraData)
        {
            base.OnRun(extraData);

            eventManager.AddListener<EventLevelNodeUnlock>(OnLevelNodeUnlocked);
        }

        protected override void OnStop()
        {
            base.OnStop();

            eventManager.RemoveListener<EventLevelNodeUnlock>(OnLevelNodeUnlocked);
        }

        private void OnLevelNodeUnlocked(EventLevelNodeUnlock e)
        {
            if (uiManager.IsPanelOpen(nameof(UIPanelLevel)))
                return;
            var uiArg = new UIPanelLevelProperties();
            uiArg.onNextClick += UiArg_onNextClick;
            uiManager.ShowPanel(nameof(UIPanelLevel), uiArg);
        }

        private void UiArg_onNextClick(UIPanelLevel obj)
        {
            Debug.Log("22222");
        }
    }
}
