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

            btnPre.advancedEvents.onClick.AddListener(() =>
            {
                Properties.OnBtnPreClick(this);
            });

            btnNext.advancedEvents.onClick.AddListener(() =>
            {
                Properties.OnBtnNextClick(this);
            });
        }
    }

    public class UIPanelLevelProperties : PanelProperties
    {
        public event Action<UIPanelLevel> onPreClick;
        public event Action<UIPanelLevel> onNextClick;

        public void OnBtnPreClick(UIPanelLevel controller)
        {
            onPreClick?.Invoke(controller);
        }
        public void OnBtnNextClick(UIPanelLevel controller)
        {
            onNextClick?.Invoke(controller);
        }
    }
}
