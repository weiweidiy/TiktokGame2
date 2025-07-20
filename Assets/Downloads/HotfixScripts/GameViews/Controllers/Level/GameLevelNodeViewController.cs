using Adic;
using Adic.Container;
using Game.Common;
using GameCommands;
using JFramework;
using JFramework.Game;
using System;
using System.Collections.Generic;
using UnityEngine;


namespace Tiktok
{
    /// <summary>
    /// 关卡节点视图控制器
    /// </summary>
    public class GameLevelNodeViewController : BaseGameController
    {
        [Inject]
        IInjectionContainer container;

        [Inject]
        TiktokConfigManager jConfigManager;

        [Inject]
        LevelsModel levelsMode;

        [Inject]
        TiktokGameObjectManager gameObjectManager;

        [Inject]
        GameLevelViewController gameLevelViewController;

        /// <summary>
        /// 当前关卡所有节点
        /// </summary>
        Dictionary<int, string> dicLevelNodesUid = new Dictionary<int, string>();
        Dictionary<string, TiktokLevelNodeView> dicLevelNodesView = new Dictionary<string, TiktokLevelNodeView>();


        [Inject]
        public GameLevelNodeViewController(EventManager eventManager) : base(eventManager)
        {
        }

        /// <summary>
        /// 在game场景才会run
        /// </summary>
        /// <param name="extraData"></param>
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
            //to do: 归还所有节点
            throw new Exception("没有处理OnStop");
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
            //if (nodes.Count == 0)
            //{
            //    var firstUid = jConfigManager.GetDefaultFirstNode();
            //    ShowNode(firstUid);

            //}
            //else
            //{
            //    foreach (var node in nodes)
            //    {
            //        //Debug.Log("关卡节点解锁了 " + node.NodeId);
            //        ShowNode(node.NodeId.ToString());

            //        var nextNodesUid = jConfigManager.GetNextLevelNode(node.NodeId.ToString());
            //        foreach (var nextNodeUid in nextNodesUid)
            //        {
            //            if (!ContainsNodeId(nodes, nextNodeUid))
            //            {
            //                ShowNode(nextNodeUid);
            //            }
            //        }
            //    }
            //}
        }

        private void OnExitLevel(EventExitLevel e)
        {
            foreach (var view in dicLevelNodesView.Values)
            {
                gameObjectManager.Return(view.gameObject);
            }

            dicLevelNodesView.Clear();
            dicLevelNodesUid.Clear();
            //dicLevelNodesBottomView.Clear();
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

        public void ShowNodes(List<string> uids)
        {
            foreach (var uid in uids)
            {
                ShowNode(uid);
            }
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

            ////创建底座
            //var goBottom = gameObjectManager.Rent(bottomPrefabData.PrefabName);
            //goBottom.transform.SetParent(gameLevelViewController.GetNode(nodeIndex));
            //goBottom.transform.localPosition = Vector3.zero;
            //dicLevelNodesBottomView.Add(Uid, goBottom);

            //创建角色
            var go = gameObjectManager.Rent(prefabData.PrefabName);
            go.transform.SetParent(gameLevelViewController.GetNode(nodeIndex));
            go.transform.localPosition = Vector3.zero;
            var nodeView = go.GetComponent<TiktokLevelNodeView>();
            dicLevelNodesView.Add(uid, nodeView);
            dicLevelNodesUid.Add(nodeView.GetHashCode(), uid);
            nodeView.onClicked += NodeView_onClicked;
        }

        public bool IsShow(string uid)
        {
            return dicLevelNodesView.ContainsKey(uid);
        }

        public void HideNode(string uid)
        {
            var view = dicLevelNodesView[uid];
            view.onClicked -= NodeView_onClicked;

            dicLevelNodesUid.Remove(view.GetHashCode());
            dicLevelNodesView.Remove(uid);

            gameObjectManager.Return(view.gameObject);
        }


        private void OnLevelNodeUpdate(EventLevelNodeUpdate e)
        {
            var data = e.Body as List<LevelNodeDTO>;
            foreach(var nodeDTO in data)
            {
                var uid = nodeDTO.NodeId;
                if (IsShow(uid))
                {
                    Debug.LogError("节点已经显示了 " + uid);
                }
                else
                {
                    ShowNode(uid);
                }
            }

           
        }

        /// <summary>
        /// 节点被点击
        /// </summary>
        /// <param name="nodeView"></param>
        private void NodeView_onClicked(TiktokLevelNodeView nodeView)
        {
            var nodeUid = dicLevelNodesUid[nodeView.GetHashCode()];
            Debug.Log(nodeUid + "  节点被点击了");
            //to do: 后续UI，比如菜单按钮，由按钮触发事件

            //debug：直接请求战斗
            var dispatcher = container.GetCommandDispatcher();
            dispatcher.Dispatch<CommandFight>(nodeUid);

        }


    }
}
