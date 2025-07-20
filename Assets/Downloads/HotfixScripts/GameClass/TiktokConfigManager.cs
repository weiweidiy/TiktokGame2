using JFramework.Game;
using Adic;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace JFramework
{
    public class TiktokConfigManager : IJConfigManager
    {
        [Inject]
        IJConfigManager jConfigManager;

        public bool IsNewLevelFirstNode(string uid)
        {
            var nodeCfgData = jConfigManager.Get<LevelsNodesCfgData>(uid);
            var preUid = nodeCfgData.PreUid;
            if (preUid == "0")
                return true;
            var preNode = jConfigManager.Get<LevelsNodesCfgData>(preUid);
            return preNode.LevelUid != nodeCfgData.LevelUid;

        }

        public string GetDefaultFirstNode()
        {
            return "1";
        }

        public List<string> GetNextLevelNode(string curUid)
        {
            var nodeCfg = jConfigManager.Get<LevelsNodesCfgData>(curUid);
            return nodeCfg.NextUid;
        }

        public string GetNextLevel(string curUid)
        {
            var levelCfg = jConfigManager.Get<LevelsCfgData>(curUid);
            return levelCfg.Next;
        }

        public string GetPreLevel(string curUid)
        {
            var levelCfg = jConfigManager.Get<LevelsCfgData>(curUid);
            return levelCfg.Pre;
        }



        public Task PreloadAllAsync(IProgress<LoadProgress> progress = null)
        {
            return jConfigManager.PreloadAllAsync(progress);
        }

        public void RegisterTable<TTable, TItem>(string path, IDeserializer deserializer)
            where TTable : IConfigTable<TItem>, new()
            where TItem : IUnique
        {
            jConfigManager.RegisterTable<TTable, TItem>(path, deserializer);
        }

        public List<TItem> Get<TItem>(Func<TItem, bool> predicate) where TItem : class, IUnique
        {
            return jConfigManager.Get<TItem>(predicate);
        }

        public TItem Get<TItem>(string uid) where TItem : class, IUnique
        {
            return jConfigManager.Get<TItem>(uid);
        }

        public List<TItem> GetAll<TItem>() where TItem : class, IUnique
        {
            return jConfigManager.GetAll<TItem>();
        }
    }

}

