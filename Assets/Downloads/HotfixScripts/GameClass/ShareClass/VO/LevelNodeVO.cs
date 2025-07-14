using JFramework;
using JFramework.Game;

namespace Tiktok
{
    public struct LevelNodeVO : IUnique, IUnlockable
    {
        public string Uid { get; set; }
        public LevelState state;

        public void Unlock()
        {
            state = LevelState.Unlocked;
        }

        public void Lock()
        {
            state = LevelState.Locked;
        }

        public bool IsLocked()
        {
            return state == LevelState.Locked;
        }
    }

}
