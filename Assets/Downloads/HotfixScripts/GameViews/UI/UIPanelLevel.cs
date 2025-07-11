using deVoid.UIFramework;
using System;
using UnityEngine;

namespace JFramework.Game.View
{
    public class UIPanelLevel : APanelController<UIPanelLevelProperties>
    {
        [SerializeField] AdvancedButton btnNext;

        protected override void OnPropertiesSet()
        {
            base.OnPropertiesSet();

            btnNext.advancedEvents.onClick.AddListener(() =>
            {
                Properties.OnBtnNextClick(this);
            });
        }
    }

    public class UIPanelLevelProperties : PanelProperties
    {
        public event Action<UIPanelLevel> onNextClick;
        public void OnBtnNextClick(UIPanelLevel controller)
        {
            onNextClick?.Invoke(controller);
        }
    }
}
