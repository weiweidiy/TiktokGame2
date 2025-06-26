using Adic;

namespace JFramework
{
    public class TiktokJNetMessageJsonSerializerStrate : JNetMessageJsonSerializerStrate
    {
        [Inject]
        public TiktokJNetMessageJsonSerializerStrate(IDataConverter dataConverter) : base(dataConverter)
        {
        }
    }
}

