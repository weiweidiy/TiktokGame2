using JFramework;
using System.Collections.Generic;

namespace Tiktok
{
    public class LevelNodeUnlockedNtf : JNetMessage
    {
        public override int TypeId => (int)ProtocolType.LevelNodeUnlockedNtf;

        public List<string> LevelNodeUid;
    }
}

