using Adic;
using Game.Common;
using JFramework;
using JFramework.Game;
using JFramework.Package;
using UnityEngine;


namespace Tiktok
{
    /// <summary>
    /// 游戏关卡控制器
    /// </summary>
    public class GameLevelViewController : BaseViewController
    {
        [Inject]
        IJConfigManager jConfigManager;

        [Inject]
        LevelsModel levelsMode;

        [Inject]
        TiktokGameObjectManager gameObjectManager;

        TiktokBackgroundView curBackgroundView;

        [Inject]
        public GameLevelViewController(CommonEventManager eventManager) : base(eventManager)
        {
        }

        protected override void OnRun(RunableExtraData extraData)
        {
            base.OnRun(extraData);

            var curLevelId = levelsMode.GetCurLevelUid();
            var cfgData = jConfigManager.Get<LevelsCfgData>(curLevelId);
            var prefabData = jConfigManager.Get<PrefabsCfgData>(cfgData.PrefabUid);


            var goLevel = gameObjectManager.Rent(prefabData.PrefabName);
            goLevel.transform.parent = gameObjectManager.GoRoot.transform;
            curBackgroundView = goLevel.GetComponent<TiktokBackgroundView>();
            //gameObjectManager.Return(goRole);
        }

        protected override void OnStop()
        {
            base.OnStop();
        }

        public Transform GetNode(int index)
        {
            return curBackgroundView.GetNode(index);
        }
    }
}
