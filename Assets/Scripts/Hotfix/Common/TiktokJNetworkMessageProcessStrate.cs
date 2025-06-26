using Adic;
using JFramework;


namespace Tiktok
{
    public class TiktokJNetworkMessageProcessStrate : JNetworkMessageProcessStrate
    {
        [Inject]
        public TiktokJNetworkMessageProcessStrate(INetMessageSerializerStrate serializer, IMessageTypeResolver typeResolver, JDataProcesserManager outProcesser, JDataProcesserManager comingProcesser) : base(serializer, typeResolver, outProcesser, comingProcesser)
        {
            typeResolver.RegisterMessageType(2, typeof(S2C_Login));
        }

     
    }
}

