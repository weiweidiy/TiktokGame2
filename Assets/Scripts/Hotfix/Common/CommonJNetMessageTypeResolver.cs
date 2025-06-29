using Adic;
using Game.Common;
using JFramework;
using System;
using System.Collections.Generic;
using Tiktok;

namespace Game.Common
{

    public class CommonJNetMessageTypeResolver : JNetMessageJsonTypeResolver
    {
        [Inject]
        public CommonJNetMessageTypeResolver(IDeserializer deserializer , INetMessageRegister register) : base(deserializer, register)
        {            
        }
    }
}

