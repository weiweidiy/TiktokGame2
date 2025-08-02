using JFramework.Game;
using Spine.Unity;
using UnityEngine;

namespace Tiktok
{
    public class SpinePlayer : MonoBehaviour, IAnimationPlayer
    {
        [SerializeField] SkeletonAnimation spine;

        public void FlipX()
        {
            spine.skeleton.FlipX = !spine.skeleton.FlipX;
        }

        public void Play(string animName, bool loop = true)
        {
            spine.AnimationState.SetAnimation(0, animName, loop);
        }

        public void Stop()
        {
            
        }
    }
}
