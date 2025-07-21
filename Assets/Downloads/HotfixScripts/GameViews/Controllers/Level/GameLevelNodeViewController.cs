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
    public class GameLevelNodeViewController : GameLevelNodeBottomViewController
    {
        [Inject]
        IInjectionContainer container;

        /// <summary>
        /// 当前关卡所有节点
        /// </summary>
        Dictionary<int, string> dicLevelNodesUid = new Dictionary<int, string>();
        //Dictionary<string, TiktokLevelNodeView> dicLevelNodesView = new Dictionary<string, TiktokLevelNodeView>();


        [Inject]
        public GameLevelNodeViewController(EventManager eventManager) : base(eventManager)
        {
        }

        protected override void OnExitLevel(EventExitLevel e)
        {
            foreach(var go in dicGameObject.Values)
            {
                go.GetComponent<TiktokLevelNodeView>().onClicked -= NodeView_onClicked;
            }

            base.OnExitLevel(e);
            dicLevelNodesUid.Clear();
            
        }

        /// <summary>
        /// 显示节点
        /// </summary>
        /// <param name="uid"></param>
        public override void ShowNode(string uid)
        {
            base.ShowNode(uid);

            var go = dicGameObject[uid];
            var nodeView = go.GetComponent<TiktokLevelNodeView>();       
            dicLevelNodesUid.Add(go.GetHashCode(), uid);
            nodeView.onClicked += NodeView_onClicked;
        }

        protected override string GetPrefabUid(LevelsNodesCfgData cfgData)
        {
            return cfgData.PrefabUid;
        }


        public override void HideNode(string uid)
        {
            var go = dicGameObject[uid];
            go.GetComponent<TiktokLevelNodeView>().onClicked -= NodeView_onClicked;
            dicLevelNodesUid.Remove(go.GetHashCode());
            
            base.HideNode(uid);
        }


        /// <summary>
        /// 节点被点击
        /// </summary>
        /// <param name="nodeView"></param>
        private void NodeView_onClicked(TiktokLevelNodeView nodeView)
        {
            var nodeUid = dicLevelNodesUid[nodeView.gameObject.GetHashCode()];
            Debug.Log(nodeUid + "  节点被点击了");
            //to do: 后续UI，比如菜单按钮，由按钮触发事件

            //debug：直接请求战斗
            var dispatcher = container.GetCommandDispatcher();
            dispatcher.Dispatch<CommandFight>(nodeUid);

        }

        protected override void UpdateNode(LevelNodeDTO updatedNode)
        {
            //跟新角色动画
            //if (dicGameObject.TryGetValue(updatedNode.Uid.ToString(), out var go))
            //{
            //    var nodeView = go.GetComponent<TiktokLevelNodeView>();
            //    if (nodeView != null)
            //    {
            //        nodeView.UpdateProcess(updatedNode.Process);
            //    }
            //}
            //else
            //{
            //    Debug.LogError("节点 " + updatedNode.Uid + " 不存在，无法更新");
            //}
        }
    }
}
