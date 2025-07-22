using JFramework;

namespace Tiktok
{
    public class GameLevelNodeStarViewController : GameLevelNodeBottomViewController
    {
        public GameLevelNodeStarViewController(EventManager eventManager) : base(eventManager)
        {
        }

        protected override string GetPrefabUid(LevelsNodesCfgData cfgData)
        {
            return cfgData.StarPrefabUid;
        }

        /// <summary>
        /// 显示节点
        /// </summary>
        /// <param name="uid"></param>
        public override void ShowNode(string uid)
        {
            base.ShowNode(uid);

            var go = dicGameObject[uid];
            var starsView = go.GetComponent<TiktokLevelNodeStarView>();   
            starsView.UpdateStars(levelsMode.GetNodeProcess(uid));
        }

        protected override void UpdateNode(LevelNodeDTO updatedNode)
        {
            var uid = updatedNode.BusinessId;
            var go = dicGameObject[uid];
            var starsView = go.GetComponent<TiktokLevelNodeStarView>();
            starsView.UpdateStars(levelsMode.GetNodeProcess(uid));
        }
    }
}
