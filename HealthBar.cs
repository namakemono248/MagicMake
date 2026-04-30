using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    public Image hpImage; // SliderではなくImageにする

    public void UpdateBar(int currentHP, int maxHP)
    {
        float targetValue = (float)currentHP / maxHP;

        // Image専用のDOTween命令「DOFillAmount」を使う！
        hpImage.DOFillAmount(targetValue, 0.5f).SetEase(Ease.OutCubic);
    }
}