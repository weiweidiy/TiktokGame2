using Cysharp.Threading.Tasks;
using JFrame.Common;

namespace JFrame
{
    public interface ITransitionProvider
    {
        UniTask<ITransition>  InstantiateAsync(string transitionType);
    }
}
