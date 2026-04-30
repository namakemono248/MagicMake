using UnityEngine;
using UnityEngine.UI;

public class WordButtonImage : MonoBehaviour
{
    public MagicSO wordData;

    // ボタンが表示された時に実行される
    void Start()
    {
        UpdateButtonImage();
    }

    // インスペクターでデータを入れ替えた時にも反映されるようにする
    void OnValidate()
    {
        UpdateButtonImage();
    }

    public void UpdateButtonImage()
    {
        if (wordData != null)
        {
            // MagicSO（親）が持っている icon を自分の Image にセットする
            GetComponent<Image>().sprite = wordData.icon;
        }
    }

    public void OnClick()
    {
        // 以前のまま：ライブラリに自分（wordData）を渡す
        FindAnyObjectByType<MagicLibrary>().AddToSpell(wordData);
    }
}