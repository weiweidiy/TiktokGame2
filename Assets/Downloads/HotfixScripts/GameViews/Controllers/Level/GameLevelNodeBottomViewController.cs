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
        protected TiktokGameObjectManager gameObjectManager;

        [Inject]
        protected GameLevelViewController gameLevelViewController;

        [Inject]
        protected TiktokConfigManager jConfigManager;

        [Inject]
        protected LevelsModel levelsMode;

        protected Dictionary<string, GameObject> dicGameObject = new Dictionary<string, GameObject>();

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

        protected virtual void OnEnterLevel(EventEnterLevel e)
        {
            var curLevelUid = (string)e.Body;
            var allNodes = jConfigManager.GetAll<LevelsNodesCfgData>();
            // Debug.LogError(allNodes.Count + "  " + jConfigManager.GetHashCode());

            var nodes = levelsMode.GetUnlockedLevelNodes(curLevelUid);
            foreach (var node in nodes)
            {
                //Debug.Log("关卡节点解锁了 " + node.Uid);
                ShowNode(node.BusinessId.ToString());
            }
        }

        public bool ContainsNodeId(List<LevelNodeDTO> nodes, string nodeUid)
        {
            foreach (var node in nodes)
            {
                if (node.BusinessId == nodeUid)
                {
                    return true;
                }
            }
            return false;
        }

        protected void ShowNodes(List<string> nextNodesUid)
        {
            foreach (var uid in nextNodesUid)
            {
                ShowNode(uid);
            }

        }

        protected virtual void OnExitLevel(EventExitLevel e)
        {

            foreach (var go in dicGameObject.Values)
            {
                gameObjectManager.Return(go);
            }

            dicGameObject.Clear();
        }

        /// <summary>
        /// 显示节点
        /// </summary>
        /// <param name="uid"></param>
        public virtual void ShowNode(string uid)
        {
            var cfgData = jConfigManager.Get<LevelsNodesCfgData>(uid);
            var bottomPrefabData = jConfigManager.Get<PrefabsCfgData>(GetPrefabUid(cfgData));
            var nodeIndex = cfgData.NodeIndex;

            //创建底座
            var goBottom = gameObjectManager.Rent(bottomPrefabData.PrefabName);
            goBottom.transform.SetParent(gameLevelViewController.GetNode(nodeIndex));
            goBottom.transform.localPosition = Vector3.zero;
            dicGameObject.Add(uid, goBottom);
        }


        protected virtual string GetPrefabUid(LevelsNodesCfgData cfgData)
        {
            return cfgData.BottomPrefabUid;
        }

        public bool IsShow(string uid)
        {
            return dicGameObject.ContainsKey(uid);
        }

        public virtual void HideNode(string uid)
        {
            var go = dicGameObject[uid];
            dicGameObject.Remove(uid);
            gameObjectManager.Return(go);
        }


        private void OnLevelNodeUpdate(EventLevelNodeUpdate e)
        {
            var data = e.Body as List<LevelNodeDTO>;
            foreach (var nodeDTO in data)
            {
                var uid = nodeDTO.BusinessId;
                if (IsShow(uid))
                {
                    //Debug.LogError("节点已经显示了 更新星星数" + nodeDTO.Process);
                    UpdateNode(nodeDTO);
                }
                else
                {
                    ShowNode(uid);
                }
            }
        }

        protected virtual void UpdateNode(LevelNodeDTO updatedNode) {}
    }
}
