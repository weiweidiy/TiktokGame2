using Adic;
using Game.Common;
using JFramework;
using JFramework.Game.View;
using JFramework.Package;
using System;
using System.Collections.Generic;
using UnityEngine;



namespace Tiktok
{
    public class GameLevelUIController : BaseGameController
    {
        [Inject]
        UIManager uiManager;

        [Inject]
        TiktokConfigManager configManager;

        string curLevelUid;

        [Inject]
        public GameLevelUIController(EventManager eventManager) : base(eventManager)
        {
        }

        protected override void OnRun(RunableExtraData extraData)
        {
            base.OnRun(extraData);

            eventManager.AddListener<EventLevelNodeUnlock>(OnLevelNodeUnlocked);
            eventManager.AddListener<EventEnterLevel>(OnEnterLevel);
        }



        protected override void OnStop()
        {
            base.OnStop();

            eventManager.RemoveListener<EventLevelNodeUnlock>(OnLevelNodeUnlocked);
            eventManager.RemoveListener<EventEnterLevel>(OnEnterLevel);
        }

        private void OnEnterLevel(EventEnterLevel e)
        {
            curLevelUid = (string)e.Body;
            Debug.Log("当前关卡 " + curLevelUid);
        }

        private void OnLevelNodeUnlocked(EventLevelNodeUnlock e)
        {
            if (uiManager.IsPanelOpen(nameof(UIPanelLevel)))
                return;

            var lstNodeUid = e.Body as List<string>;
            foreach (var uid in lstNodeUid)
            {
                if (configManager.IsNewLevelFirstNode(uid))
                {
                    var uiArg = new UIPanelLevelProperties();
                    uiArg.onPreClick += UiArg_onPreClick;
                    uiArg.onNextClick += UiArg_onNextClick;
                    uiManager.ShowPanel(nameof(UIPanelLevel), uiArg);
                    return;
                }
            } 
        }

        private void UiArg_onPreClick(UIPanelLevel obj)
        {
            eventManager.Raise<EventSwitchLevel>(curLevelUid);
        }

        private void UiArg_onNextClick(UIPanelLevel obj)
        {
            Debug.Log("switch level");
            eventManager.Raise<EventSwitchLevel>(curLevelUid + 1);
        }
    }
}
