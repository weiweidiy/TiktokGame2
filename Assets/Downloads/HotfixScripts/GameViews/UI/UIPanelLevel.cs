using deVoid.UIFramework;
using System;
using UnityEngine;

namespace JFramework.Game.View
{
    public class UIPanelLevel : APanelController<UIPanelLevelProperties>
    {
        [SerializeField] AdvancedButton btnPre;
        [SerializeField] AdvancedButton btnNext;

        protected override void OnPropertiesSet()
        {
            base.OnPropertiesSet();

            Refresh();

            btnPre.advancedEvents.onClick.AddListener(() =>
            {
                Properties.OnBtnPreClick(this);
            });

            btnNext.advancedEvents.onClick.AddListener(() =>
            {
                Properties.OnBtnNextClick(this);
            });

            Properties.onRefresh += Properties_onRefresh;
        }

        private void Properties_onRefresh()
        {
            Refresh();
        }

        void Refresh()
        {
            btnPre.gameObject.SetActive(Properties.preLevelValid);
            btnNext.gameObject.SetActive(Properties.nextLevelValid);
        }
    }

    public class UIPanelLevelProperties : PanelProperties
    {
        public event Action onRefresh;

        public event Action<UIPanelLevel> onPreClick;
        public event Action<UIPanelLevel> onNextClick;

        public bool preLevelValid { get; set; }
        public bool nextLevelValid { get; set; }

        public void OnBtnPreClick(UIPanelLevel controller)
        {
            onPreClick?.Invoke(controller);
        }
        public void OnBtnNextClick(UIPanelLevel controller)
        {
            onNextClick?.Invoke(controller);
        }

        public void Refresh()
        {
            onRefresh?.Invoke();
        }
    }
}
