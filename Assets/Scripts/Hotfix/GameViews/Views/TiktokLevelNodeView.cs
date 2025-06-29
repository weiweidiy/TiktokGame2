using UnityEngine;

namespace Tiktok
{
    public class TiktokLevelNodeView : MonoBehaviour
    {
        [SerializeField] AnimatorPlayer animPlayer;

        public void PlayIdle()
        {
            animPlayer.Play("Idle");
        }

        public void PlayDead()
        {
            animPlayer.Play("Dead");
        }
    }
}
