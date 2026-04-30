using UnityEngine;

[CreateAssetMenu(menuName = "倍率魔法")]
public class MultiplierMagicSO : MagicSO
{
    public float multiplierValue = 2.0f; // 2倍

    public override void Execuet(EnemyManager target, int basePower, ref float currentMultiplier)
    {
        // 倍率を掛け算する
        currentMultiplier *= multiplierValue;
        Debug.Log($"{wordName}を発動！ 次の威力が {currentMultiplier}倍 になった！");
    }
}