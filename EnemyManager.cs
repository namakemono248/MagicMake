using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int maxHP = 100;
    public EnemySO enemyData;
    public int currentHP;
    public HealthBar healthBar;

    void Start()
    {
        if (enemyData != null)
        {
            currentHP = enemyData.maxHP;
        }
    }

    void Awake()
    {
        // ゲーム開始時にHPを全回復させる
        currentHP = maxHP;
    }

    // ダメージを受ける処理（他のスクリプトから呼ぶ）
    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        currentHP = Mathf.Clamp(currentHP, 0, maxHP); // 0〜最大値の間に収める

        // バーをアニメーション更新！
        healthBar.UpdateBar(currentHP, maxHP);
        Debug.Log($"プレイヤーが {damage} ダメージ受けた！ 残りHP: {currentHP}");

        if (currentHP <= 0)
        {
            Debug.Log("ゲームオーバー...");
        }
    }

    public void Heal(int amount)
    {
        currentHP += amount;
        currentHP = Mathf.Min(currentHP, maxHP);

        // 回復時も同じように呼ぶだけ！
        healthBar.UpdateBar(currentHP, maxHP);
    }
}
