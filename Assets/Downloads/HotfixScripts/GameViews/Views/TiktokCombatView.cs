using System;
using UnityEngine;
using UnityEngine.UI;

namespace Tiktok
{
    public class TiktokCombatView : MonoBehaviour
    {
        public event Action<TiktokCombatView> onMaskClicked;

        [SerializeField] AdvancedButton btnClose;

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
    }
}
