using Cysharp.Threading.Tasks;
using JFrame;
using UnityEngine;

namespace Tiktok
{
    public abstract class TiktokSceneState : BaseState<TiktokSceneSMContext>
    {
        public override UniTask OnEnter(TiktokSceneSMContext context)
        {
            Debug.Log(GetType().Name + "OnEnter");
            return base.OnEnter(context);
        }

        public override UniTask OnExit()
        {
            Debug.Log(GetType().Name + "OnExit");
            return base.OnExit();
        }
    }
}
