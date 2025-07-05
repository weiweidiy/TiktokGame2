using Adic;
using JFramework;


namespace Game.Common
{
    public class CommonClientJNetworkMessageProcessStrate : JNetworkMessageProcessStrate
    {
        [Inject]
        public CommonClientJNetworkMessageProcessStrate(INetMessageSerializerStrate serializer, [Inject("Client")] IMessageTypeResolver typeResolver, JDataProcesserManager outProcesser, JDataProcesserManager comingProcesser) : base(serializer, typeResolver, outProcesser, comingProcesser)
        {
            
        }

     
    }

    public class CommonServerJNetworkMessageProcessStrate : JNetworkMessageProcessStrate
    {
        [Inject]
        public CommonServerJNetworkMessageProcessStrate(INetMessageSerializerStrate serializer, [Inject("Server")] IMessageTypeResolver typeResolver, JDataProcesserManager outProcesser, JDataProcesserManager comingProcesser) : base(serializer, typeResolver, outProcesser, comingProcesser)
        {

        }


    }
}

