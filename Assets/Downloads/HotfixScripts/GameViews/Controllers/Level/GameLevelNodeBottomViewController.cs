using Adic;
using Game.Common;
using JFramework;
using JFramework.Game;
using System;
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
        TiktokConfigManager jConfigManager;

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

            eventManager.AddListener<EventLevelNodeUpdate>(OnLevelNodeUpdate);
            eventManager.AddListener<EventEnterLevel>(OnEnterLevel);
            eventManager.AddListener<EventExitLevel>(OnExitLevel);

            //SetStartComplete();
        }

        protected override void OnStop()
        {
            base.OnStop();

            eventManager.RemoveListener<EventLevelNodeUpdate>(OnLevelNodeUpdate);
            eventManager.RemoveListener<EventEnterLevel>(OnEnterLevel);
            eventManager.RemoveListener<EventExitLevel>(OnExitLevel);
        }

        private void OnEnterLevel(EventEnterLevel e)
        {
            var curLevelUid = (string)e.Body;
            var allNodes = jConfigManager.GetAll<LevelsNodesCfgData>();
            // Debug.LogError(allNodes.Count + "  " + jConfigManager.GetHashCode());

            var nodes = levelsMode.GetUnlockedLevelNodes(curLevelUid);
            foreach (var node in nodes)
            {
                //Debug.Log("关卡节点解锁了 " + node.NodeId);
                ShowNode(node.NodeId.ToString());
            }
        }

        public bool ContainsNodeId(List<LevelNodeDTO> nodes, string nodeUid)
        {
            foreach (var node in nodes)
            {
                if (node.NodeId == nodeUid)
                {
                    return true;
                }
            }
            return false;
        }

        private void ShowNodes(List<string> nextNodesUid)
        {
            foreach (var uid in nextNodesUid)
            {
                ShowNode(uid);
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

        public bool IsShow(string uid)
        {
            return dicLevelNodesBottomView.ContainsKey(uid);
        }

        public void HideNode(string uid)
        {
            var go = dicLevelNodesBottomView[uid];
            dicLevelNodesBottomView.Remove(uid);
            gameObjectManager.Return(go);
        }


        private void OnLevelNodeUpdate(EventLevelNodeUpdate e)
        {
            var data = e.Body as List<LevelNodeDTO>;
            foreach (var nodeDTO in data)
            {
                var uid = nodeDTO.NodeId;
                if (IsShow(uid))
                {
                    Debug.LogError("节点已经显示了 更新星星数" + uid);
                }
                else
                {
                    ShowNode(uid);
                }
            }

        }
    }
}
