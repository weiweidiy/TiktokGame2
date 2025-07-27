using Adic;
using Game.Common;
using JFramework;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        IAssetsLoader assetsLoader;

        [Inject]
        public GameLevelViewController(EventManager eventManager) : base(eventManager)
        {
        }

        protected override void OnStart(RunableExtraData extraData)
        {
            base.OnStart(extraData);

            eventManager.AddListener<EventLevelNodeUpdate>(OnLevelNodeUpdate);
            eventManager.AddListener<EventSwitchLevel>(OnSwitchLevel);

            //SetStartComplete();
        }



        protected override void OnStop()
        {
            base.OnStop();

            eventManager.RemoveListener<EventLevelNodeUpdate>(OnLevelNodeUpdate);
            eventManager.RemoveListener<EventSwitchLevel>(OnSwitchLevel);
        }


        private void OnLevelNodeUpdate(EventLevelNodeUpdate e)
        {
            var nodes = e.Body as List<LevelNodeDTO>;

            //foreach (var uid in nodes) {

            //    if(jConfigManager.IsNewLevelFirstNode(uid))
            //    {
            //        //Debug.LogError("新关卡解锁了 " );
            //    }
            //}
            
        }


        public Transform GetNode(int index)
        {
            return curBackgroundView.GetNode(index);
        }

        public Transform GetRoot() => curBackgroundView.transform;

        /// <summary>
        /// 进入指定关卡
        /// </summary>
        /// <param name="uid"></param>
        public async void EnterLevel(string uid)
        {
            //var curLevelId = levelsModel.GetCurLevelUid();
            var cfgData = jConfigManager.Get<LevelsCfgData>(uid);
            var textures = cfgData.Textures;
            var prefabData = jConfigManager.Get<PrefabsCfgData>(cfgData.PrefabUid);
            var goLevel = gameObjectManager.Rent(prefabData.PrefabName);
            goLevel.transform.parent = gameObjectManager.GoRoot.transform;
            curBackgroundView = goLevel.GetComponent<TiktokBackgroundView>();
            var sprite = await assetsLoader.LoadAssetAsync<Sprite>(textures[0]);
            curBackgroundView.SetBackground(sprite);

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
