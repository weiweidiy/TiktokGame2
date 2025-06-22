using Adic;
using Adic.Container;
using deVoid.UIFramework;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JFramework.Game.View
{
    public class UIPanelMenuController : APanelController<UIPanelMenuProperties>
    {
        [SerializeField] Button btnEnter;
        [SerializeField] TextMeshProUGUI txtConfirm;

        protected override void OnPropertiesSet()
        {
            base.OnPropertiesSet();

            btnEnter.onClick.AddListener(() =>
            {
                Properties.OnBtnEnterClick(this);
            });
        }
    }


    public class UIPanelMenuProperties : PanelProperties
    {
        public event Action<UIPanelMenuController> onBtnEnterclick;

        public void OnBtnEnterClick(UIPanelMenuController controller)
        {
            onBtnEnterclick?.Invoke(controller);
        }
    }


}
