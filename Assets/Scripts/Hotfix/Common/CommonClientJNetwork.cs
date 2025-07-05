using Adic;
using JFramework;

namespace Game.Common
{
    public class CommonClientJNetwork : JNetwork
    {
        [Inject]
        public CommonClientJNetwork(ISocketFactory socketFactory, IJTaskCompletionSourceManager<IUnique> taskManager, [Inject("Client")] INetworkMessageProcessStrate messageProcessStrate) : base(socketFactory, taskManager, messageProcessStrate)
        {

        }
    }

    //public class CommonServerJNetwork : JNetwork
    //{
    //    [Inject]
    //    public CommonServerJNetwork(ISocketFactory socketFactory, IJTaskCompletionSourceManager<IUnique> taskManager, [Inject("Server")] INetworkMessageProcessStrate messageProcessStrate) : base(socketFactory, taskManager, messageProcessStrate)
    //    {

    //    }
    //}
}

