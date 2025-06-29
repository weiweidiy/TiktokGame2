using Adic;
using JFramework;
using JFramework.Game;

namespace Tiktok
{
    public class SocketFactory : ISocketFactory
    {
        [Inject]
        IJConfigManager jConfigManager;

        [Inject]
        IDataManager dataManager;

        public IJSocket Create()
        {
            return new FakeSocket(jConfigManager, dataManager);
        }
    }
}

