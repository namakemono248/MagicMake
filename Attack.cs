using UnityEngine;

public class Attack : MonoBehaviour
{
    public MagicLibrary library;

    // 敵ボタン(button)がクリックされたら呼び出す
    public void OnEnemyClicked(EnemyController enemy)
    {
        if (library == null || library.currentSpell.Count == 0) return;

        // 計算処理
        int totalDamage = 0;

        foreach (var word in library.currentSpell)
        {
            int p = word.power;

            if (word.attribute == enemy.enemyData.weaknessAttribute)
            {
                p *= 2;
            }
            totalDamage += p;
        }

        enemy.currentHP -= totalDamage;
        Debug.Log($"{enemy.enemyData.enemyName}に{totalDamage}ダメージ！　残りHP:{enemy.currentHP}");

        if (enemy.currentHP <= 0)
        {
            enemy.gameObject.SetActive(false);
        }

        library.ClearSpell();
    }
}