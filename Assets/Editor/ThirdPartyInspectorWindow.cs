using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using Tiktok;
using JFramework;

public class ThirdPartyInspectorWindow : OdinEditorWindow
{
    [MenuItem("Tools/Third Party Inspector")]
    private static void OpenWindow()
    {
        var window = GetWindow<ThirdPartyInspectorWindow>();
        window.titleContent = new GUIContent("Third Party Inspector");

        window.Show();
    }

    // Ŀ����󣨿��������븳ֵ��
    [ShowInInspector, HideLabel, BoxGroup("Target")]
    public object Target { get; set; }

    // ��ʾ�����ֶΣ�����˽���ֶΣ�
    [ShowInInspector, BoxGroup("Fields"), ListDrawerSettings(IsReadOnly = true, Expanded = true)]
    public List<FieldInfo> AllFields => GetAllFields();

    // ��ʾ�������ԣ�����˽�����ԣ�
    [ShowInInspector, BoxGroup("Properties"), ListDrawerSettings(IsReadOnly = true, Expanded = true)]
    public List<PropertyInfo> AllProperties => GetAllProperties();

    // ��ȡ�ֶ�ֵ��֧���޸ģ�
    [ShowInInspector, BoxGroup("Field Values")]
    public Dictionary<string, object> FieldValues
    {
        get => GetFieldValues();
        set => SetFieldValues(value);
    }

    // ��ȡ�����ֶΣ�����˽�У�
    private List<FieldInfo> GetAllFields()
    {
        if (Target == null) return new List<FieldInfo>();
        return Target.GetType()
            .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
            .ToList();
    }

    // ��ȡ�������ԣ�����˽�У�
    private List<PropertyInfo> GetAllProperties()
    {
        if (Target == null) return new List<PropertyInfo>();
        return Target.GetType()
            .GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
            .ToList();
    }

    // ��ȡ�ֶ�ֵ
    private Dictionary<string, object> GetFieldValues()
    {
        var dict = new Dictionary<string, object>();
        if (Target == null) return dict;

        foreach (var field in GetAllFields())
        {
            dict[field.Name] = field.GetValue(Target);
        }
        return dict;
    }

    // �޸��ֶ�ֵ
    private void SetFieldValues(Dictionary<string, object> values)
    {
        if (Target == null) return;

        foreach (var field in GetAllFields())
        {
            if (values.TryGetValue(field.Name, out var newValue))
            {
                field.SetValue(Target, newValue);
            }
        }
    }

    protected override void OnEnable()
    {
        base.OnEnable();

        var container = GameObject.Find("Container").GetComponent<TiktokContainerMain>().Container;
        Target = container.Resolve<LevelsModel>();
    }
}