using JFramework;

namespace Tiktok
{
    public class SocketFactory : ISocketFactory
    {
        public IJSocket Create()
        {
            return new FakeSocket();
        }
    }
}

