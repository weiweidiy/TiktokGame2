using Adic;
using Game.Common;
using JFramework;
using JFramework.Game;
using System.Collections.Generic;
using UnityEngine;


namespace Tiktok
{
    public class GameLevelNodeBottomViewController : BaseGameController
    {
        [Inject]
        TiktokGameObjectManager gameObjectManager;

        [Inject]
        GameLevelViewController gameLevelViewController;

        [Inject]
        IJConfigManager jConfigManager;

        [Inject]
        LevelsModel levelsMode;

        Dictionary<string, GameObject> dicLevelNodesBottomView = new Dictionary<string, GameObject>();

        [Inject]
        public GameLevelNodeBottomViewController(EventManager eventManager) : base(eventManager)
        {
        }

        protected override void OnStart(RunableExtraData extraData)
        {
            base.OnStart(extraData);

            eventManager.AddListener<EventLevelNodeUnlock>(OnLevelNodeUnlock);
            eventManager.AddListener<EventEnterLevel>(OnEnterLevel);
            eventManager.AddListener<EventExitLevel>(OnExitLevel);

            //SetStartComplete();
        }

        protected override void OnStop()
        {
            base.OnStop();

            eventManager.RemoveListener<EventLevelNodeUnlock>(OnLevelNodeUnlock);
            eventManager.RemoveListener<EventEnterLevel>(OnEnterLevel);
            eventManager.RemoveListener<EventExitLevel>(OnExitLevel);
        }

        private void OnEnterLevel(EventEnterLevel e)
        {
            var curLevelUid = (string)e.Body;
            var allNodes = jConfigManager.GetAll<LevelsNodesCfgData>();
            // Debug.LogError(allNodes.Count + "  " + jConfigManager.GetHashCode());

            var nodes = levelsMode.GetLevelNodes(curLevelUid);
            for (int i = 0; i < nodes.Count; i++)
            {
                var node = nodes[i];
                if (node.state == LevelState.Unlocked)
                {
                    ShowNode(node.Uid);
                }
            }
        }

        private void OnExitLevel(EventExitLevel e)
        {

            foreach (var go in dicLevelNodesBottomView.Values)
            {
                gameObjectManager.Return(go);
            }

            dicLevelNodesBottomView.Clear();
        }

        /// <summary>
        /// 显示节点
        /// </summary>
        /// <param name="uid"></param>
        public void ShowNode(string uid)
        {
            var cfgData = jConfigManager.Get<LevelsNodesCfgData>(uid);
            var prefabData = jConfigManager.Get<PrefabsCfgData>(cfgData.PrefabUid);
            var bottomPrefabData = jConfigManager.Get<PrefabsCfgData>(cfgData.BottomPrefabUid);
            var nodeIndex = cfgData.NodeIndex;

            //创建底座
            var goBottom = gameObjectManager.Rent(bottomPrefabData.PrefabName);
            goBottom.transform.SetParent(gameLevelViewController.GetNode(nodeIndex));
            goBottom.transform.localPosition = Vector3.zero;
            dicLevelNodesBottomView.Add(uid, goBottom);


        }

        public void HideNode(string uid)
        {
            //var view = dicLevelNodesView[Uid];
            //view.onClicked -= NodeView_onClicked;

            //dicLevelNodesUid.Remove(view.GetHashCode());
            //dicLevelNodesView.Remove(Uid);

            var go = dicLevelNodesBottomView[uid];
            dicLevelNodesBottomView.Remove(uid);
            gameObjectManager.Return(go);
        }


        private void OnLevelNodeUnlock(EventLevelNodeUnlock e)
        {
            var data = e.Body as List<string>;
            foreach (var uid in data)
            {
                //Debug.Log("关卡解锁了 " + uid);
                ShowNode(uid);
            }

        }
    }
}
