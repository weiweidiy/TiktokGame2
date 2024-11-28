using UnityEngine;
using UnityEngine.UI;

public class MyGuideMask : MonoBehaviour, ICanvasRaycastFilter
{
    public Image _Mask; //����ͼƬ
    private Material _materia;
    private GameObject target;

    private void Awake()
    {
        _materia = _Mask.material;
    }

    /// <summary>
    /// ����Բ�Ǿ�������
    /// </summary>
    /// <param name="pos">���ε���Ļλ��</param>
    /// <param name="pos1">���½�λ��</param>
    /// <param name="pos2">���Ͻ�λ��</param>
    public void CreateCircleRectangleMask(Vector2 pos, Vector2 widthAndHeight, float raid, bool isHorizontal = true)
    {
        _materia.SetFloat("_MaskType", isHorizontal ? 2f : 3f);
        _materia.SetVector("_Origin", new Vector4(pos.x, pos.y, widthAndHeight.x, widthAndHeight.y));
        _materia.SetFloat("_Raid", raid);
    }

    /// <summary>
    /// �������ε������
    /// </summary>
    /// <param name="pos">�������ĵ�����</param>
    /// <param name="widthAndHeight">���ο��</param>
    public void CreateRectangleMask(Vector2 pos, Vector2 widthAndHeight, float raid)
    {
        _materia.SetFloat("_MaskType", 1f);
        _materia.SetVector("_Origin", new Vector4(pos.x, pos.y, widthAndHeight.x, widthAndHeight.y));
    }

    /// <summary>
    /// ����˫Բ�ε������
    /// </summary>
    /// <param name="pos">��Բ�����ĵ�����</param>
    /// <param name="rad">��Բ�ΰ뾶</param>
    /// <param name="pos1">СԲ�����ĵ�����</param>
    /// <param name="rad1">СԲ�ΰ뾶</param>
    public void CreateCircleMask(Vector3 pos, float rad, Vector3 pos1, float rad1)
    {
        _materia.SetFloat("_MaskType", 0f);
        _materia.SetVector("_Origin", new Vector4(pos.x, pos.y, rad, 0));
        _materia.SetVector("_TopOri", new Vector4(pos1.x, pos1.y, rad1, 0));
    }

    /// <summary>
    /// ����Ŀ�겻��Mask�ڵ�
    /// </summary>
    /// <param name="tg">Ŀ��</param>
    public void SetTargetImage(GameObject tg)
    {
        target = tg;
    }

    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
        //û��Ŀ����׽�¼���͸
        if (target == null)
        {
            return true;
        }

        //��Ŀ�귶Χ�����¼���͸
        return !RectTransformUtility.RectangleContainsScreenPoint(target.GetComponent<RectTransform>(),
            sp, eventCamera);
    }
}