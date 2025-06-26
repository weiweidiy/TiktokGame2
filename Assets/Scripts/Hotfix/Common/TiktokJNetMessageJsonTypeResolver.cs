using Adic;

namespace JFramework
{
    public class TiktokJNetMessageJsonTypeResolver : JNetMessageJsonTypeResolver
    {
        [Inject]
        public TiktokJNetMessageJsonTypeResolver(IDeserializer deserializer) : base(deserializer)
        {
        }
    }
}

