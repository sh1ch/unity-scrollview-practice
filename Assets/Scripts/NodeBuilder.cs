using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeBuilder : MonoBehaviour
{
    [SerializeField]
    private RectTransform NodePrefab;

    private int Count = 15;

    private string[] Charactors = new string[] 
    {
        // 5
        "ランス",
        "シィル",
        "あてな２号",
        "サチコ",
        "イージス",
        // 5
        "パットン",
        "アレックス",
        "リック",
        "上杉謙信",
        "山本五十六",
        // 5
        "魔想志津香",
        "リズナ",
        "マリア",
        "ホーネット",
        "カミーラ",
    };


    // Start is called before the first frame update
    void Start()
    {
        if (NodePrefab == null) return;

        for (var i = 0; i < Count; i++)
        {
            var node = Instantiate(NodePrefab) as RectTransform;

            node.SetParent(transform, false);

            var text = node.GetComponentInChildren<Text>();
            var image = node.GetComponentInChildren<Image>();

            text.text = Charactors[i];
            text.color = new Color32(50, 50, 50, 255);

            if (i % 2 == 0)
            {
                image.color = new Color32(244, 244, 244, 255);
            }
            else
            {
                image.color = new Color32(182, 226, 245, 255);
            }

        }
    }

}
