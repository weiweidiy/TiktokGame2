using Adic;
using Game.Common;
using JFramework;

using System;
using System.Collections.Generic;

using UnityEngine;


namespace Tiktok
{
    /// <summary>
    /// 游戏关卡控制器
    /// </summary>
    public class GameLevelViewController : BaseGameController
    {
        //[Inject]
        //IJConfigManager jConfigManager;

        [Inject]
        TiktokConfigManager jConfigManager;

        [Inject]
        LevelsModel levelsMode;

        [Inject]
        TiktokGameObjectManager gameObjectManager;

        [Inject]
        ITransitionProvider transitionProvider;

        TiktokBackgroundView curBackgroundView;

        [Inject]
        public GameLevelViewController(EventManager eventManager) : base(eventManager)
        {
        }

        protected override void OnStart(RunableExtraData extraData)
        {
            base.OnStart(extraData);

            eventManager.AddListener<EventLevelNodeUnlock>(OnNodeUnlocked);
            eventManager.AddListener<EventSwitchLevel>(OnSwitchLevel);

            SetStartComplete();
        }



        protected override void OnStop()
        {
            base.OnStop();

            eventManager.RemoveListener<EventLevelNodeUnlock>(OnNodeUnlocked);
            eventManager.RemoveListener<EventSwitchLevel>(OnSwitchLevel);
        }


        private void OnNodeUnlocked(EventLevelNodeUnlock e)
        {
            var nodes = e.Body as List<string>;

            foreach (var uid in nodes) {

                if(jConfigManager.IsNewLevelFirstNode(uid))
                {
                    Debug.LogError("新关卡解锁了 " );
                }
            }
            
        }


        public Transform GetNode(int index)
        {
            return curBackgroundView.GetNode(index);
        }

        /// <summary>
        /// 进入指定关卡
        /// </summary>
        /// <param name="uid"></param>
        public void EnterLevel(string uid)
        {
            //var curLevelId = levelsMode.GetCurLevelUid();
            var cfgData = jConfigManager.Get<LevelsCfgData>(uid);
            var prefabData = jConfigManager.Get<PrefabsCfgData>(cfgData.PrefabUid);
            var goLevel = gameObjectManager.Rent(prefabData.PrefabName);
            goLevel.transform.parent = gameObjectManager.GoRoot.transform;
            curBackgroundView = goLevel.GetComponent<TiktokBackgroundView>();

            eventManager.Raise<EventEnterLevel>(uid);
        }

        /// <summary>
        /// 退出当前关卡
        /// </summary>
        public void ExitCurLevel()
        {
            gameObjectManager.Return(curBackgroundView.gameObject);
            curBackgroundView = null;
            eventManager.Raise<EventExitLevel>(null);
        }

        private async void OnSwitchLevel(EventSwitchLevel e)
        {
            var targetUid = (string)e.Body;

            var transition = await transitionProvider.InstantiateAsync(TransitionType.SMBlindsTransition.ToString());
            await transition.TransitionOut();
            ExitCurLevel();
            EnterLevel(targetUid);
            await transition.TransitionIn();
        }
    }
}
