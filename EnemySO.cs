using UnityEngine;

[CreateAssetMenu(menuName = "敵ステータス")]
public class EnemySO : ScriptableObject
{
    public string enemyName;
    public Sprite icon;
    public int maxHP;
    public int power;
    public int attackSpeed;
    public string weaknessAttribute;
}