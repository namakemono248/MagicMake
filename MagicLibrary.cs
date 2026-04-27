using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicLibrary : MonoBehaviour
{
    public List<MagicSO> currentSpell = new List<MagicSO>();
    public int maxSlots = 4;
    public GameObject[] magicImage;

    public void AddToSpell(MagicSO wordData)
    {
        if (currentSpell.Count < maxSlots)
        {
            currentSpell.Add(wordData);
            Debug.Log(wordData.wordName + "をセットしました");

            int index = currentSpell.Count - 1;
            Image image = magicImage[index].GetComponent<Image>();
            image.sprite = wordData.icon;
        }
    }

    public void ClearSpell()
    {
        currentSpell.Clear();
        Debug.Log("スロットを空にしました");

        foreach (GameObject magicObj in magicImage)
        {
            Image image = magicObj.GetComponent<Image>();
            image.sprite = null;
        }
    }
}
