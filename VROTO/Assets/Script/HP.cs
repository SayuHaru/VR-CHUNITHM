using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public static int maxHP = 100;
    public static int crrentHP;
    public static int damage = 1;
    public static int cancel = 0;
    public GameObject result;
    public GameObject GO;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
        crrentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = (float)crrentHP / (float)maxHP;
        if (slider.value == 0)
        {
            result.SetActive(true);
            GO.SetActive(true);
            cancel = 1;
        }
    }
}
