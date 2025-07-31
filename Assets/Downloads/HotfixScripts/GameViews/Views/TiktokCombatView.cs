using Game.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Tiktok
{
    public class TiktokCombatView : MonoBehaviour
    {
        public event Action<TiktokCombatView> onMaskClicked;

        [SerializeField] AdvancedButton btnClose;

        [SerializeField] Transform[] tranSeats;

        private void OnEnable()
        {
            btnClose.onClick.AddListener(OnCloseButtonClicked);
        }


        private void OnDisable()
        {
            btnClose.onClick.RemoveListener(OnCloseButtonClicked);
        }

        private void OnCloseButtonClicked()
        {
            onMaskClicked?.Invoke(this);
        }

        public Transform GetSeat(int index)
        {
            return tranSeats != null && index >= 0 && index < tranSeats.Length ? tranSeats[index] : null;
        }
    }
}
