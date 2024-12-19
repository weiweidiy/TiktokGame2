using Cysharp.Threading.Tasks;

namespace JFrame
{
    public interface ITransition
    {
        UniTask<SMTransitionState> TransitionOut();
        UniTask<SMTransitionState> TransitionIn();
    }
}
