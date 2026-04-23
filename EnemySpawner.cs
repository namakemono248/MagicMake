using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    public StageDataSO currentStge;
    public List<EnemyController> enemyButtons;

    void Start()
    {
        SpawnEnemies();
    }

    public void SpawnEnemies()
    {
        if (currentStge == null || currentStge.appearanceEnemies.Count == 0)
        {
            return;
        }

        foreach (var enemyCtrl in enemyButtons)
        {
            int randomIndex = Random.Range(0, currentStge.appearanceEnemies.Count);
            EnemySO selectedEnemy = currentStge.appearanceEnemies[randomIndex];

            enemyCtrl.enemyData = selectedEnemy;
            enemyCtrl.currentHP = selectedEnemy.maxHP;
            enemyCtrl.gameObject.SetActive(true);
            enemyCtrl.GetComponent<Image>().sprite = selectedEnemy.icon;

            Debug.Log($"敵ボタンに{selectedEnemy.enemyName}を割り当てました");
        }
    }
}
