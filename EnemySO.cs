using UnityEngine;

[CreateAssetMenu]
public class EnemySO : ScriptableObject
{
    public string enemyName;
    public Sprite icon;
    public int maxHP;
    public int power;
    public string weaknessAttribute;
}