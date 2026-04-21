using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemySO enemyData;
    public int currentHP;

    void Start()
    {
        if (enemyData != null)
        {
            currentHP = enemyData.maxHP;
        }
    }
}
