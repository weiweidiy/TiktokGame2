using Adic;
using Game.Common;
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
        Dictionary<int, string> dicLevelNodesView = new Dictionary<int, string>();

        [Inject]
        public GameLevelNodeViewController(CommonEventManager eventManager) : base(eventManager)
        {
        }

        protected override void OnRun(RunableExtraData extraData)
        {
            base.OnRun(extraData);

            var nodes = levelsMode.GetLevelNodes(levelsMode.GetCurLevelUid());
            for (int i = 0; i < nodes.Count; i++)
            {
                var node = nodes[i];
                if (node.state == LevelState.Unlocked)
                {
                    var cfgData = jConfigManager.Get<LevelsNodesCfgData>(node.uid);
                    var prefabData = jConfigManager.Get<PrefabsCfgData>(cfgData.PrefabUid);

                    var go = gameObjectManager.Rent(prefabData.PrefabName);
                    go.transform.SetParent(gameLevelViewController.GetNode(i));
                    go.transform.localPosition = Vector3.zero;
                    var nodeView = go.GetComponent<TiktokLevelNodeView>();
                    dicLevelNodesView.Add(nodeView.GetHashCode(), node.uid);
                    nodeView.onClicked += NodeView_onClicked;
                }
            }
        }

        private async void NodeView_onClicked(TiktokLevelNodeView nodeView)
        {
            var nodeUid = dicLevelNodesView[nodeView.GetHashCode()];
            Debug.Log(nodeUid + "  节点被点击了");
            var req = new FightReq();
            req.Uid = Guid.NewGuid().ToString();
            req.LevelNodeUid = nodeUid;
            var response = await jNetwork.SendMessage<FightRes>(req);

        }

        protected override void OnStop()
        {
            base.OnStop();
        }
    }
}
