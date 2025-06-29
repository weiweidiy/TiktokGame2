using Adic;
using JFramework;
using JFramework.Game;

namespace Tiktok
{
    public class SocketFactory : ISocketFactory
    {
        [Inject]
        IJConfigManager jConfigManager;

        public IJSocket Create()
        {
            return new FakeSocket(jConfigManager);
        }
    }
}

