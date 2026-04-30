using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("基本ステータス")]
    public int maxHP = 100;
    public int currentHP;
    public int money = 0;
    public int level = 1;
    public HealthBar healthBar;

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

    // お金を追加する処理
    public void AddMoney(int amount)
    {
        money += amount;
        Debug.Log($"{amount}円手に入れた！ 所持金: {money}円");
    }
}