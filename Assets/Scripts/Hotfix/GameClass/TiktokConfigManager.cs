using JFramework.Game;
using Adic;

namespace JFramework
{
    public class TiktokConfigManager : JConfigManager
    {       

        [Inject]
        public TiktokConfigManager(IConfigLoader loader, IDeserializer deserializer) : base(loader)
        {
            RegisterTable<LevelsTable, LevelsCfgData>(nameof(LevelsTable), deserializer);
            RegisterTable<LevelsNodesTable, LevelsNodesCfgData>(nameof(LevelsNodesTable), deserializer);
            RegisterTable<PrefabsTable, PrefabsCfgData>(nameof(PrefabsTable), deserializer);
        }

        //[Inject]
        //public void Init(IDeserializer deserializer)
        //{

        //}
    }

}

