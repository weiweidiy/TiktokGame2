//using Chronos;
using UnityEngine;

public class ScrollUVController : MonoBehaviour
{
    /// <summary>
    /// ��ǰ�ٶ�
    /// </summary>
    private float curSpeed;

    /// <summary>
    /// Ŀ���ٶ�
    /// </summary>
    public float targetSpeed;

    /// <summary>
    /// ��ǰ����
    /// </summary>
    Material _material;

    /// <summary>
    /// uiƫ��
    /// </summary>
    float _uvX = 0f;

    // Start is called before the first frame update
    //Timeline m_TimeLine;

    void Awake()
    {
        _material = GetComponent<SpriteRenderer>().material;
        //m_TimeLine = GetComponent<Timeline>();
    }

    private void Update()
    {
        //Debug.Assert(m_TimeLine != null, "û���ҵ�timeline" +gameObject);
        float deltaTime = GetDeltaTime();
        deltaTime *= Time.timeScale;
        _uvX += deltaTime * curSpeed;
        SetUVX(_uvX);
    }

    /// <summary>
    /// Ĭ�ϵ�ϵͳ�Դ���ʧʱ��
    /// </summary>
    /// <returns></returns>
    protected virtual float GetDeltaTime()
    {
        return Time.deltaTime; 
    }

    /// <summary>
    /// ����uv��ֵ
    /// </summary>
    /// <param name="uvX"></param>
    public virtual void SetUVX(float uvX)
    {
        _material.SetFloat("_UVX", uvX);
    }

    /// <summary>
    /// �����ƶ��ٶȣ��ͻ���ͨ�����õ�ǰ�ٶ�ֵ������
    /// </summary>
    /// <param name="speed"></param>
    public void SetSpeed(float speed)
    {
        this.curSpeed = speed;
    }

    /// <summary>
    /// ��ȡ��ǰ�ٶ�
    /// </summary>
    /// <returns></returns>
    public float GetSpeed()
    {
        return curSpeed;
    }

    /// <summary>
    /// ����UV
    /// </summary>
    public void ResetUVX()
    {
        _uvX = 0f;
    }

    /// <summary>
    /// ���ò���
    /// </summary>
    /// <param name="tex"></param>
    public void SetTexture(Texture2D tex)
    {
        _material.SetTexture("_MainTexture", tex);
    }
}
