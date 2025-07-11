namespace JFramework.Game
{
    public interface IAnimationPlayer
    {
        void Play(string animName, bool loop = true);

        void Stop();
    }
}
