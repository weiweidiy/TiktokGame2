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
        // ���߼����������
        // ����Ļ����ת��Ϊ��������
        var ray = Camera.main.ScreenPointToRay(finger.ScreenPosition);
        var hit = Physics2D.Raycast(ray.origin, ray.direction);

        if (hit.collider != null && hit.collider.gameObject == gameObject)
        {
            //Debug.Log("��������2D����");
            onClicked?.Invoke();
        }
    }
}