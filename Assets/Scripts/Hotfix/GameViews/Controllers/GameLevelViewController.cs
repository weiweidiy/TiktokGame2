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
        public GameLevelViewController(CommonEventManager eventManager) : base(eventManager)
        {
        }

        protected override void OnRun(RunableExtraData extraData)
        {
            base.OnRun(extraData);

            var lst = jConfigManager.GetAll<LevelsData>();
            foreach (var level in lst)
            {
                Debug.Log(level.Name);
            }
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
