using Lean.Touch;
using System;
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    public event Action onClicked;

    private void OnEnable()
    {
        LeanTouch.OnFingerTap += HandleFingerTap;
    }

    private void OnDisable()
    {
        LeanTouch.OnFingerTap -= HandleFingerTap;
    }

    private void HandleFingerTap(LeanFinger finger)
    {
        // 射线检测点击的物体
        // 将屏幕坐标转换为世界坐标
        var ray = Camera.main.ScreenPointToRay(finger.ScreenPosition);
        var hit = Physics2D.Raycast(ray.origin, ray.direction);

        if (hit.collider != null && hit.collider.gameObject == gameObject)
        {
            //Debug.Log("点击了这个2D物体");
            onClicked?.Invoke();
        }
    }
}