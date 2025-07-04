﻿using Adic;
using Adic.Container;
using Game.Common;
using GameCommands;
using JFramework;
using JFramework.Game;
using JFramework.Package;
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
        public GameLevelNodeViewController(EventManager eventManager, BaseClassPool classPool) : base(eventManager, classPool)
        {
        }

        /// <summary>
        /// 在game场景才会run
        /// </summary>
        /// <param name="extraData"></param>
        protected override void OnRun(RunableExtraData extraData)
        {
            base.OnRun(extraData);

            var allNodes = jConfigManager.GetAll<LevelsNodesCfgData>();
           // Debug.LogError(allNodes.Count + "  " + jConfigManager.GetHashCode());

            var nodes = levelsMode.GetLevelNodes(levelsMode.GetCurLevelUid());
            for (int i = 0; i < nodes.Count; i++)
            {
                var node = nodes[i];
                if (node.state == LevelState.Unlocked)
                {
                    ShowNode(node.uid);
                }
            }

            eventManager.AddListener<EventLevelNodeUnlock>(OnLevelNodeUnlock);

        }

        protected override void OnStop()
        {
            base.OnStop();

            eventManager.RemoveListener<EventLevelNodeUnlock>(OnLevelNodeUnlock);
            //to do: 归还所有节点
            throw new Exception("没有处理OnStop");


        }

        /// <summary>
        /// 显示节点
        /// </summary>
        /// <param name="uid"></param>
        public void ShowNode(string uid)
        {
            var cfgData = jConfigManager.Get<LevelsNodesCfgData>(uid);
            var prefabData = jConfigManager.Get<PrefabsCfgData>(cfgData.PrefabUid);
            var nodeIndex = cfgData.NodeIndex;

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
            var data = e.Body as LevelNodeUnlockedNtf;
            foreach (var uid in data.LevelNodeUid)
            {
                Debug.Log("关卡解锁了 " + uid);
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
