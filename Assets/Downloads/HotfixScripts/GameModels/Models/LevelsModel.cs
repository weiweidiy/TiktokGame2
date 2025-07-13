using Adic;
using JFramework;
using JFramework.Game;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Tiktok
{
    public class LevelsModel : BaseModel<LevelData>
    {
        IJConfigManager jConfigManager;

        [Inject]
        public LevelsModel(EventManager eventManager, IJConfigManager jConfigManager) : base(eventManager)
        {
            this.jConfigManager = jConfigManager;
        }


        /// <summary>
        /// 获取所有指定关卡的所有节点数据
        /// </summary>
        /// <param name="levelUid"></param>
        /// <returns></returns>
        public List<LevelNodeVO> GetLevelNodes(string levelUid)
        {
            var result = new List<LevelNodeVO>();

            foreach (var vo in data.LevelsData.Values)
            {
                var cfgData = jConfigManager.Get<LevelsNodesCfgData>(vo.uid);
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
        public bool IsUnlocked(string levelUid)
        {
            var nodes = GetLevelNodes(levelUid);
            foreach (var node in nodes)
            {
                if(node.state == LevelState.Unlocked)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 解锁
        /// </summary>
        /// <param name="nodesUid"></param>
        /// <returns></returns>
        public async Task<List<string>> UnlockNodes(List<string> nodesUid)
        {
            var result = new List<string>();
            foreach (string nodeUid in nodesUid)
            {

                var success = UnlockNode(nodeUid);
                if (success) result.Add(nodeUid);
            }

            await OnUnlock(result);

            return result;
        }

        /// <summary>
        /// 解锁单个节点
        /// </summary>
        /// <param name="nodeUid"></param>
        /// <returns></returns>
        protected bool UnlockNode(string nodeUid)
        {
            if (nodeUid == "0")
                return false;

            var levelData = Data;

            //var cfgData = jConfigManager.Get<LevelsNodesCfgData>(nodeUid);
            var vo = Data.LevelsData[nodeUid];

            if (vo.state == LevelState.Unlocked) //已经解锁了，所以不用解锁了
                return false;

            vo.state = LevelState.Unlocked;
            Data.LevelsData[nodeUid] = vo;

            return true;
        }

        /// <summary>
        /// 解锁后续处理
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        protected virtual Task OnUnlock(List<string> result)
        {
            //发消息，服务器可以是存档
            SendEvent<EventLevelNodeUnlock>(result);
            return Task.CompletedTask;
        }

       
    }

}
