using UnityEngine;

public class Attack : MonoBehaviour
{
    public MagicLibrary library;

    // 敵ボタン(button)がクリックされたら呼び出す
    public void OnEnemyClicked(EnemyController enemy)
    {
        if (library == null || library.currentSpell.Count == 0) return;

        // 計算処理
        int basePower = 0;
        float currentMultiplier = 1.0f; // ★最初は1倍

        foreach (var word in library.currentSpell)
        {
            word.Execuet(enemy, basePower, ref currentMultiplier);
        }

        Debug.Log($"残りHP:{enemy.currentHP}\n魔法発動完了!!");

        if (enemy.currentHP <= 0)
        {
            enemy.gameObject.SetActive(false);
        }

        library.ClearSpell();
    }
}
