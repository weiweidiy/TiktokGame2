using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[System.Serializable]
public class AdvancedButtonEvents
{
    public UnityEvent onClick = new UnityEvent();
    public UnityEvent onLongPressStart = new UnityEvent();
    public UnityEvent onLongPressEnd = new UnityEvent();
    public UnityEvent onLongPressComplete = new UnityEvent(); // 新增：长按完成事件
}

public class AdvancedButton : Button
{
    [Header("Timing Settings")]
    [Tooltip("Minimum time between clicks in seconds")]
    public float minClickInterval = 0.5f;
    [Tooltip("How long to hold for long press in seconds")]
    public float longPressDuration = 1f;
    [Tooltip("If true, will trigger long press complete event when long press duration is reached")]
    public bool triggerLongPressComplete = true;

    [Header("Events")]
    public AdvancedButtonEvents advancedEvents;

    private float _lastClickTime;
    private bool _isPointerDown;
    private bool _isLongPress;
    private float _pointerDownTime;

    protected override void Awake()
    {
        base.Awake();
        // 将原有的 onClick 事件转移到我们的 advancedEvents.onClick
        onClick.AddListener(() => advancedEvents.onClick.Invoke());
    }

    private void Update()
    {
        if (!_isPointerDown || _isLongPress) return;

        if (Time.time - _pointerDownTime >= longPressDuration)
        {
            _isLongPress = true;
            advancedEvents.onLongPressStart.Invoke();

            if (triggerLongPressComplete)
            {
                advancedEvents.onLongPressComplete.Invoke();
            }
        }
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        _isPointerDown = true;
        _isLongPress = false;
        _pointerDownTime = Time.time;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);

        if (_isLongPress)
        {
            advancedEvents.onLongPressEnd.Invoke();
        }

        _isPointerDown = false;
        _isLongPress = false;
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        if (_isLongPress) return;

        if (Time.time - _lastClickTime >= minClickInterval)
        {
            _lastClickTime = Time.time;
            base.OnPointerClick(eventData); // 这会触发原始的 onClick 事件
        }
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        base.OnPointerExit(eventData);

        if (_isPointerDown && _isLongPress)
        {
            advancedEvents.onLongPressEnd.Invoke();
        }

        _isPointerDown = false;
        _isLongPress = false;
    }

    // 禁用/启用按钮的便捷方法
    public void SetInteractable(bool interactable)
    {
        this.interactable = interactable;
        if (!interactable)
        {
            _isPointerDown = false;
            _isLongPress = false;
        }
    }
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
//    Debug.Log("按钮被点击");
//}

//private void OnLongPressStart()
//{
//    Debug.Log("长按开始");
//}

//private void OnLongPressEnd()
//{
//    Debug.Log("长按结束");
//}

//private void OnLongPressComplete()
//{
//    Debug.Log("长按完成（达到指定时长）");
//}