using Adic;
using Game.Common;
using JFramework;
using JFramework.Game;
using JFramework.Package;


namespace Tiktok
{
    public class GameLevelNodeViewController : BaseViewController
    {
        [Inject]
        IJConfigManager jConfigManager;

        [Inject]
        LevelsModel levelsMode;

        [Inject]
        TiktokGameObjectManager gameObjectManager;

        [Inject]
        public GameLevelNodeViewController(CommonEventManager eventManager) : base(eventManager)
        {
        }

        protected override void OnRun(RunableExtraData extraData)
        {
            base.OnRun(extraData);

            //var curLevelId = levelsMode

        }

        protected override void OnStop()
        {
            base.OnStop();
        }
    }
}
