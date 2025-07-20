//using Adic;
//using JFramework;
//using JFramework.Game;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Tiktok;
//using UnityEngine;


//namespace Tiktok
//{
//    public class LevelsManager : LevelsModel
//    {
//        IJConfigManager jConfigManager;

//        IGameDataStore dataStore;

//       [Inject]
//        public LevelsManager(CommonEventManager eventManager, IJConfigManager jConfigManager, IGameDataStore dataStore, Func<LevelNodeVO, string> keySelector) : base(eventManager, jConfigManager, keySelector)
//        {
//            this.jConfigManager = jConfigManager;
//            this.dataStore = dataStore;
//        }

//        //protected override async Task OnUnlock(List<string> result)
//        //{
//        //    if (result.Count > 0)
//        //        await dataStore.SaveAsync(nameof(LevelData), Data);
//        //}

//    }
//}

