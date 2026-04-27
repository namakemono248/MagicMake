using UnityEngine;

public abstract class MagicSO : ScriptableObject
{
    public string wordName;
    public Sprite icon;
    public abstract void Execuet(EnemyController target, int bassPowwer, ref float multiplier);
}
