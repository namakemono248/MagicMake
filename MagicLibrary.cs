using System.Collections.Generic;
using UnityEngine;

public class MagicLibrary : MonoBehaviour
{
    public List<MagicSO> currentSpell = new List<MagicSO>();
    public int maxSlots = 4;

    public void AddToSpell(MagicSO word)
    {
        if (currentSpell.Count < maxSlots)
        {
            currentSpell.Add(word);
            Debug.Log(word.wordName + "をセットしました");
        }
    }

    public void ClearSpell()
    {
        currentSpell.Clear();
        Debug.Log("スロットを空にしました");
    }
}
