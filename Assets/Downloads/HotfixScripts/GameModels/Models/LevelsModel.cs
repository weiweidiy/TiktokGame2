using Adic;
using JFramework;
using JFramework.Game;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


namespace Tiktok
{
    public class LevelsModel : BaseDictionaryModel<LevelNodeDTO> //  BaseModel<LevelData>
    {
        TiktokConfigManager jConfigManager;

        [Inject]
        public LevelsModel(EventManager eventManager, TiktokConfigManager jConfigManager, Func<LevelNodeDTO, string> keySelector) : base(keySelector,eventManager)
        {
            this.jConfigManager = jConfigManager;
        }

        public void Initialize(List<LevelNodeDTO> unlockedNodes)
        {
            AddRange(unlockedNodes);

            if(unlockedNodes.Count == 0)
            {
                //如果没有解锁的节点，则添加第一个默认节点
                var firstNodeUid = jConfigManager.GetDefaultFirstNode();
                if (firstNodeUid != null)
                {
                    var firstNode = new LevelNodeDTO
                    {
                        BusinessId = firstNodeUid,
                        Process = 0
                    };
                    Add(firstNode);
                }
            }
            else
                //更新并添加后置节点
                AddNextNodes(unlockedNodes); 
        }


        List<LevelNodeDTO> AddNextNodes(List<LevelNodeDTO> targetNodes)
        {
            var result = new List<LevelNodeDTO>();

            foreach (var node in targetNodes)
            {
                var nextNodesUid = jConfigManager.GetNextLevelNode(node.BusinessId.ToString());
                foreach (var nextNodeUid in nextNodesUid)
                {
                    if (nextNodeUid == "0" || node.Process > 1)
                        continue;

                    if (Get(nextNodeUid) == null)
                    {
                        var nextNode = new LevelNodeDTO
                        {
                            BusinessId = nextNodeUid,
                            Process = 0
                        };
                        Add(nextNode);
                        result.Add(nextNode);
                    }
                }
            }
            return result;
        }


        /// <summary>
        /// 获取所有指定关卡的已经解锁的所有节点数据
        /// </summary>
        /// <param name="levelUid"></param>
        /// <returns></returns>
        public List<LevelNodeDTO> GetUnlockedLevelNodes(string levelUid)
        {
            var result = new List<LevelNodeDTO>();

            foreach (var vo in GetAll())
            {
                var cfgData = jConfigManager.Get<LevelsNodesCfgData>(vo.BusinessId.ToString());
                if (cfgData.LevelUid == levelUid)
                {
                    result.Add(vo);
                }
            }

            return result;
        }

        /// <summary>
        /// 指定关卡是否解锁了
        /// </summary>
        /// <param name="levelUid"></param>
        /// <returns></returns>
        public bool IsLevelUnlocked(string levelUid)
        {
            var nodes = GetUnlockedLevelNodes(levelUid);
            return nodes.Count > 0;
        }

        /// <summary>
        /// <!-更新节点数据--->
        /// </summary>
        /// <param name="updatedNode"></param>
        public void UpdateNode(LevelNodeDTO updatedNode)
        {
            UpdateData(updatedNode);

            var nextNodes = AddNextNodes(new List<LevelNodeDTO> { updatedNode });
            var needUpdateNodes = new List<LevelNodeDTO> { updatedNode };
            needUpdateNodes.AddRange(nextNodes);

            foreach(var node in needUpdateNodes)
                UnityEngine.Debug.Log(" node uid " + node.BusinessId + " process " + node.Process);

            SendEvent<EventLevelNodeUpdate>(needUpdateNodes);

        }

        public int GetNodeProcess(string nodeUid)
        {
            if (string.IsNullOrEmpty(nodeUid))
                return 0;
            var node = Get(nodeUid);
            if (node != null)
                return node.Process;
            return 0;
        }

        ///// <summary>
        ///// 解锁
        ///// </summary>
        ///// <param name="nodesUid"></param>
        ///// <returns></returns>
        //public async Task<List<string>> UnlockNodes(List<string> nodesUid)
        //{
        //    var result = new List<string>();
        //    foreach (string nodeUid in nodesUid)
        //    {

        //        var success = UnlockNode(nodeUid);
        //        if (success) result.Add(nodeUid);
        //    }

        //    await OnUnlock(result);

        //    return result;
        //}

        ///// <summary>
        ///// 解锁单个节点
        ///// </summary>
        ///// <param name="nodeUid"></param>
        ///// <returns></returns>
        //protected bool UnlockNode(string nodeUid)
        //{
        //    if (nodeUid == "0")
        //        return false;

        //    return Unlock(nodeUid);
        //}

        ///// <summary>
        ///// 解锁后续处理
        ///// </summary>
        ///// <param name="result"></param>
        ///// <returns></returns>
        //protected virtual Task OnUnlock(List<string> result)
        //{
        //    //发消息，服务器可以是存档
        //    SendEvent<EventLevelNodeUpdate>(result);

        //    return Task.CompletedTask;
        //}

        //protected override void OnUpdateTData(List<LevelNodeDTO> unlockableDatas)
        //{
        //    Data.UnlockedLevelNodesData = unlockableDatas;
        //}
    }

}
