using JFramework.Game;
using Spine.Unity;
using UnityEngine;

namespace Tiktok
{
    public class AnimatorPlayer : MonoBehaviour,  IAnimationPlayer
    {
        [SerializeField] Animator animator;

        public void FlipX()
        {
            throw new System.NotImplementedException();
        }

        public void Play(string animName, bool loop = true)
        {
            animator.Play(animName);
        }

        public void SetAnimation(string path, bool flipX = false)
        {
            throw new System.NotImplementedException();
        }

        public void Stop()
        {
            
        }
    }
}
