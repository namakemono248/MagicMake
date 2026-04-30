using UnityEngine;

public class Test : MonoBehaviour
{
    public int damage;
    public PlayerManager playerManager;

    public void OnClick()
    {
        playerManager.TakeDamage(10);
    }
}
