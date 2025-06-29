using Adic;
using JFramework;

namespace Game.Common
{
    public class CommonJNetwork : JNetwork
    {
        [Inject]
        public CommonJNetwork(ISocketFactory socketFactory, IJTaskCompletionSourceManager<IUnique> taskManager, INetworkMessageProcessStrate messageProcessStrate) : base(socketFactory, taskManager, messageProcessStrate)
        {

        }
    }
}

