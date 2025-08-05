using DG.Tweening;
using JFramework.Game;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Tiktok
{
    public class DoTweenPlayer : MonoBehaviour, IAnimationPlayer
    {
        [SerializeField] bool playOnEnable;


        private void OnEnable()
        {
            Play("", false);
        }

        public void FlipX()
        {
            //throw new System.NotImplementedException();
        }
        public async Task Play(string animName, bool loop = true)
        {
            var tcs = new TaskCompletionSource<bool>();
            var tweener = transform.DOLocalMoveY(1f, 0.5f).SetLoops(loop ? -1 : 1,LoopType.Restart)
                .SetEase(Ease.InOutSine);

            tweener.OnComplete(() =>
            {
                tcs.SetResult(true);
            });

            await tcs.Task;
        }

        public void SetAnimation(string path, bool flipX = false)
        {
            //throw new System.NotImplementedException();
        }
        public void Stop()
        {
            //throw new System.NotImplementedException();
        }
    }
}
