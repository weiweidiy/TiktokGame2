using Adic;
using Game.Common;
using JFramework;
using JFramework.Package;


namespace Tiktok
{
    /// <summary>
    /// 游戏关卡控制器
    /// </summary>
    public class GameLevelController : BaseViewController
    {
        [Inject]
        public GameLevelController(CommonEventManager eventManager) : base(eventManager)
        {
        }

        protected override void OnRun(RunableExtraData extraData)
        {
            base.OnRun(extraData);
            
        }

        protected override void OnStop()
        {
            base.OnStop();
        }
    }

    public class GameUnitController : BaseViewController
    {
        [Inject]
        public GameUnitController(CommonEventManager eventManager) : base(eventManager)
        {
        }
    }
}
