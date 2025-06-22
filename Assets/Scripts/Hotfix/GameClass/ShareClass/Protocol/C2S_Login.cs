using JFramework;
using System;

namespace Tiktok
{
    public class C2S_Login : JNetMessage
    {

    }

    public class S2C_Login : JNetMessage
    {
        public int Code;

        public LevelData LevelData;
    }
}

