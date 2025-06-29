using System;
using UnityEngine;

namespace Tiktok
{
    public class TiktokLevelNodeView : MonoBehaviour
    {
        public event Action<TiktokLevelNodeView> onClicked;

        [SerializeField] AnimatorPlayer animPlayer;
        [SerializeField] ClickDetector clickDetector;

        void OnEnable()
        {
            clickDetector.onClicked += ClickDetector_onClicked;
        }

        void OnDisable()
        {
            clickDetector.onClicked -= ClickDetector_onClicked;
        }


        private void ClickDetector_onClicked()
        {
            onClicked?.Invoke(this);
        }

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
