using UnityEngine;

[CreateAssetMenu(menuName = "攻撃魔法")]
public class DamageMagicSO : MagicSO
{
    public int power;
    public override void Execuet(EnemyController target, int bassPowwer, ref float multiplier)
    {
        int finalDamage = Mathf.RoundToInt((power + bassPowwer) * multiplier);

        // ダメージを与える
        target.currentHP -= finalDamage;

        // ★ ここでログを出す！
        // $を使うと、変数の中身を文章に混ぜるのが楽になります
        Debug.Log($"{wordName}を発動！ {target.enemyData.enemyName}に {finalDamage} ダメージ与えた！");
    }
}
