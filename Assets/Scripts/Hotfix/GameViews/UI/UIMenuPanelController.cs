using Adic;
using Adic.Container;
using deVoid.UIFramework;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JFrame.Game.View
{
    public class UIMenuPanelController : APanelController<UIMenuPanelProperties>
    {
        [SerializeField] Button btnEnter;

        protected override void OnPropertiesSet()
        {
            base.OnPropertiesSet();

            btnEnter.onClick.AddListener(() =>
            {
                Properties.OnBtnEnterClick();
            });
        }
    }

    public class UIMenuPanelProperties : PanelProperties
    {
        public event Action onBtnEnterclick;

        public void OnBtnEnterClick()
        {
            onBtnEnterclick?.Invoke();
        }
    }
}
