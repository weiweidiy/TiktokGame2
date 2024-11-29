//using Sirenix.OdinInspector;

using DG.Tweening;

namespace JFrame.Common
{
    public class DotweenTimer : ITimer
    {
        Tween tween;
        public DotweenTimer(Tween tween)
        {
            this.tween = tween;
        }
        public void Stop()
        {
            this.tween.Kill();
        }
    }
}
