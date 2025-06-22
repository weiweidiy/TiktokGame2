using Adic;
using JFramework;
using JFramework.Game;
using System.Collections.Generic;


namespace Tiktok
{
    public class LevelsModel : BaseModel<List<LevelVO>>
    {
        [Inject]
        public LevelsModel(CommonEventManager eventManager) : base(eventManager)
        {
        }
    }

}
