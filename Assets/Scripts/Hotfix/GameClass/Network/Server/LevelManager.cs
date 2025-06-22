using JFramework;
using JFramework.Game;
using System.Collections;
using System.Collections.Generic;
using Tiktok;
using UnityEngine;


namespace Tiktok
{
    public class LevelManager : BaseModel<List<LevelVO>>
    {
        public LevelManager(CommonEventManager eventManager) : base(eventManager)
        {
        }
    }
}

