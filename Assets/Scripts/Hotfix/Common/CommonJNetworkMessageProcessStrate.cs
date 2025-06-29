using Adic;
using JFramework;


namespace Game.Common
{
    public class CommonJNetworkMessageProcessStrate : JNetworkMessageProcessStrate
    {
        [Inject]
        public CommonJNetworkMessageProcessStrate(INetMessageSerializerStrate serializer, IMessageTypeResolver typeResolver, JDataProcesserManager outProcesser, JDataProcesserManager comingProcesser) : base(serializer, typeResolver, outProcesser, comingProcesser)
        {
            
        }

     
    }
}

