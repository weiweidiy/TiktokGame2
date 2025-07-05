using Adic;
using Game.Common;
using JFramework;
using System;
using System.Collections.Generic;
using Tiktok;

namespace Game.Common
{

    public class CommonClientJNetMessageTypeResolver : JNetMessageJsonTypeResolver
    {
        [Inject]
        public CommonClientJNetMessageTypeResolver(IDeserializer deserializer , [Inject("Client")] INetMessageRegister register) : base(deserializer, register)
        {            
        }
    }

    public class CommonServerJNetMessageTypeResolver : JNetMessageJsonTypeResolver
    {
        [Inject]
        public CommonServerJNetMessageTypeResolver(IDeserializer deserializer, [Inject("Server")] INetMessageRegister register) : base(deserializer, register)
        {
        }
    }
}

