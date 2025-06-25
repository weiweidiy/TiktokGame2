using JFramework.Game;
using Adic;

namespace JFramework
{
    public class TiktokConfigManager : JConfigManager
    {
        [Inject]
        public TiktokConfigManager(IConfigLoader loader) : base(loader)
        {
        }
    }

}

