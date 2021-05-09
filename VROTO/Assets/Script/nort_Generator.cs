using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nort_Generator : MonoBehaviour
{
    public static float t ;
    public GameObject nort1;
    public int count = 0;

    // Start is called before the first frame update
    void Start()

    {
       // count = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (HP.cancel == 0)
        {
            t = Time.time;
            //      Debug.Log(t);
            if (count == 1)
            {
                count = 2;
            }
            if (t >= 0 && count == 0)
            {
                Instantiate(nort1, this.transform.position, Quaternion.identity);
                gameObject.SetActive(false);
                count = 1;
            }
            if (count == 2)
            {
                count = 0;

            }
        }
       
    }
}
