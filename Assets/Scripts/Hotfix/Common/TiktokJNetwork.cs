using Adic;

namespace JFramework
{
    public class TiktokJNetwork : JNetwork
    {
        [Inject]
        public TiktokJNetwork(ISocketFactory socketFactory, IJTaskCompletionSourceManager<IUnique> taskManager, INetworkMessageProcessStrate messageProcessStrate) : base(socketFactory, taskManager, messageProcessStrate)
        {

        }
    }
}

