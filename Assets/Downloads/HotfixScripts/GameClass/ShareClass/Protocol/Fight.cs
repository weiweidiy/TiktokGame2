using JFramework;

namespace Tiktok
{
    public class FightReq: JNetMessage
    {
        public override int TypeId => (int)ProtocolType.FightReq;

        public string LevelNodeUid;
    }

    public class FightRes: ProtocalRes
    {
        public override int TypeId => (int)ProtocolType.FightRes;
    }
}

