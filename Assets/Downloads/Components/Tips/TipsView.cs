using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Common
{
    public class TipsView : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI tipsText;
        [SerializeField] CanvasGroup canvasGroup;

        private Tween fadeTween;

        private void OnEnable()
        {
            // ����ֹ֮ǰ�Ķ������������
            fadeTween?.Kill();

            // ��ʼ͸��
            canvasGroup.alpha = 0f;

            // ����0.5�� -> ͣ��1�� -> ����0.5��
            fadeTween = canvasGroup.DOFade(1f, 0.5f)
                .OnComplete(() =>
                {
                    // ͣ��1��󵭳�
                    fadeTween = canvasGroup.DOFade(0f, 0.5f)
                        .SetDelay(1f);
                });
        }

        private void OnDisable()
        {
            // �ر�ʱ��ֹ����
            fadeTween?.Kill();

            tipsText.text = string.Empty;
        }

        public void Show(string message)
        {
            tipsText.text = message;
        }
    }
}