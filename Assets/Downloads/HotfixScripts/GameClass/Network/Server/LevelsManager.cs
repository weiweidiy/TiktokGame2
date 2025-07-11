using Adic;
using JFramework;
using JFramework.Game;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiktok;
using UnityEngine;


namespace Tiktok
{
    public class LevelsManager : LevelsModel
    {
        IJConfigManager jConfigManager;

        IGameDataStore dataStore;

       [Inject]
        public LevelsManager(CommonEventManager eventManager, IJConfigManager jConfigManager, IGameDataStore dataStore) : base(eventManager, jConfigManager)
        {
            this.jConfigManager = jConfigManager;
            this.dataStore = dataStore;
        }

        //public async Task<List<string>> TryUnlockNodes(List<string> nodesUid)
        //{
        //    var result = UnlockNodes(nodesUid);     

        //    return result;
        //}

        protected override async Task OnUnlock(List<string> result)
        {
            if (result.Count > 0)
                await dataStore.SaveAsync(nameof(LevelData), Data);
        }

    }
}

