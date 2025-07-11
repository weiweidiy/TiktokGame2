using JFramework.Game;
using UnityEngine;

namespace Tiktok
{
    public class AnimatorPlayer : MonoBehaviour,  IAnimationPlayer
    {
        [SerializeField] Animator animator;
        public void Play(string animName, bool loop = true)
        {
            animator.Play(animName);
        }

        public void Stop()
        {
            
        }
    }
}
