using Adic;
using Game.Common;
using JFramework;
using JFramework.Game.View;
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

        [Inject]
        LevelsModel levelModel;

        string preLevelUid;
        string curLevelUid;
        string nextLevelUid;


        UIPanelLevelProperties uiArg; 

        [Inject]
        public GameLevelUIController(EventManager eventManager) : base(eventManager)
        {
        }

        protected override void OnStart(RunableExtraData extraData)
        {
            base.OnStart(extraData);

            eventManager.AddListener<EventLevelNodeUpdate>(OnLevelNodeUpdate);
            eventManager.AddListener<EventEnterLevel>(OnEnterLevel);

            uiArg = new UIPanelLevelProperties();
            uiArg.onPreClick += UiArg_onPreClick;
            uiArg.onNextClick += UiArg_onNextClick;

            //SetStartComplete();
        }



        protected override void OnStop()
        {
            base.OnStop();

            eventManager.RemoveListener<EventLevelNodeUpdate>(OnLevelNodeUpdate);
            eventManager.RemoveListener<EventEnterLevel>(OnEnterLevel);

            uiArg.onPreClick -= UiArg_onPreClick;
            uiArg.onNextClick -= UiArg_onNextClick;
        }

        private void OnEnterLevel(EventEnterLevel e)
        {
            curLevelUid = (string)e.Body;
            Debug.Log("当前关卡 " + curLevelUid);
            //如果没有前一关，没有后一关则返回，否则显示切换UI
            preLevelUid = configManager.GetPreLevel(curLevelUid);
            nextLevelUid = configManager.GetNextLevel(curLevelUid);
            ShowUIPanelLevel(preLevelUid != "0", levelModel.IsLevelUnlocked(nextLevelUid));
        }

        void ShowUIPanelLevel(bool preValid, bool nextValid)
        {
            uiArg.preLevelValid = preValid;
            uiArg.nextLevelValid = nextValid;

            if (uiManager.IsPanelOpen(nameof(UIPanelLevel)))
            {
                uiArg.Refresh();
            }
            else
            {
                uiManager.ShowPanel(nameof(UIPanelLevel), uiArg);
            }

        }

        private void OnLevelNodeUpdate(EventLevelNodeUpdate e)
        {
            //if (uiManager.IsPanelOpen(nameof(UIPanelLevel)))
            //    return;

            var data = e.Body as List<LevelNodeDTO>;
            foreach (var nodeDTO in data)
            {
                var uid = nodeDTO.BusinessId.ToString();
                if (configManager.IsNewLevelFirstNode(uid))
                {
                    //Debug.Log("新关卡解锁了~");
                    ShowUIPanelLevel(preLevelUid != "0", levelModel.IsLevelUnlocked(nextLevelUid));
                    return;
                }
            }
            
            
        }

        private void UiArg_onPreClick(UIPanelLevel obj)
        {
            eventManager.Raise<EventSwitchLevel>(preLevelUid);
        }

        private void UiArg_onNextClick(UIPanelLevel obj)
        {
            Debug.Log("switch level " + nextLevelUid);
            eventManager.Raise<EventSwitchLevel>(nextLevelUid);
        }
    }
}
