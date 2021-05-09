using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;  // 追加しましょう

public class ComboManager : MonoBehaviour
{


    public GameObject score_object = null; // Textオブジェクト
    public static float Combo = 0f;
    public static int ComboPonit = 10;
    public GameObject Full;
    public GameObject result;
    public GameObject Finish;
    // 初期化
    void Start()
    {
    }

    // 更新
    void Update()
    {
        float ti = Time.time;
      //  Debug.Log(ti);
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Combo : " +Combo;
        if (Combo >= 30)
        {
            ComboPonit = 12;
        }
        if (Combo >= 50)
        {
            ComboPonit = 13;
        }
        if (Combo >= 75)
        {
            ComboPonit = 14;
        }
        if (Combo >= 100)
        {
            ComboPonit = 15;
        }
        if (Combo >= 125)
        {
            ComboPonit = 16;
        }
        if (Combo >= 150)
        {
            ComboPonit = 17;
        }
        if (Combo >= 175)
        {
            ComboPonit = 18;
        }

        if (Combo >= 180 && ti >= 98.50)
        {
            Full.SetActive(true);
            result.SetActive(true);
        }
        else if (ti >= 98.50)
        {
            Finish.SetActive(true);
            result.SetActive(true);
        }
    }
}