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
        IJConfigManager jConfigManager;

        [Inject]
        IJNetwork jNetwork; //用命令代替

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
            //to do: 归还所有节点
            throw new Exception("没有处理OnStop");
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
            foreach (var view in dicLevelNodesView.Values)
            {
                gameObjectManager.Return(view.gameObject);
            }

            //foreach(var go in dicLevelNodesBottomView.Values)
            //{
            //    gameObjectManager.Return(go);
            //}

            dicLevelNodesView.Clear();
            dicLevelNodesUid.Clear();
            //dicLevelNodesBottomView.Clear();
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

        public void HideNode(string uid)
        {
            var view = dicLevelNodesView[uid];
            view.onClicked -= NodeView_onClicked;

            dicLevelNodesUid.Remove(view.GetHashCode());
            dicLevelNodesView.Remove(uid);

            gameObjectManager.Return(view.gameObject);
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
