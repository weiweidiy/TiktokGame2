using UnityEngine.Events;

[System.Serializable]
public class AdvancedButtonEvents
{
    public UnityEvent onClick = new UnityEvent();
    public UnityEvent onLongPressStart = new UnityEvent();
    public UnityEvent onLongPressEnd = new UnityEvent();
    public UnityEvent onLongPressComplete = new UnityEvent(); // ��������������¼�
}

//public AdvancedButton myButton;

//private void Start()
//{
//    myButton.advancedEvents.onClick.AddListener(OnClick);
//    myButton.advancedEvents.onLongPressStart.AddListener(OnLongPressStart);
//    myButton.advancedEvents.onLongPressEnd.AddListener(OnLongPressEnd);
//    myButton.advancedEvents.onLongPressComplete.AddListener(OnLongPressComplete);
//}

//private void OnClick()
//{
//    Debug.Log("��ť�����");
//}

//private void OnLongPressStart()
//{
//    Debug.Log("������ʼ");
//}

//private void OnLongPressEnd()
//{
//    Debug.Log("��������");
//}

//private void OnLongPressComplete()
//{
//    Debug.Log("������ɣ��ﵽָ��ʱ����");
//}