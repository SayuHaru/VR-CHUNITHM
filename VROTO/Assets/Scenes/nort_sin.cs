using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nort_sin : MonoBehaviour
{
    private Vector3 last;
    public static float speed = 1.5f;
    public GameObject particle;
    public GameObject particle2;
    public GameObject particle3;
    float step = 0;

    void Start()
    {
        last = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP.cancel == 0)
        {
            step = step - Time.deltaTime;
            transform.position = new Vector3(last.x, last.y, last.z + step * speed);
            if (transform.position.z <= -0.75)
            {
                ScoreManager.Score = ScoreManager.Score - 10;
                Instantiate(particle3, this.transform.position, particle.transform.rotation);
                HP.crrentHP = HP.crrentHP - HP.damage;
                ComboManager.Combo =  0;
                //            ComboManager.Combo = 0;

                Destroy(this.gameObject);

            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (HP.cancel ==0) {
            if (other.gameObject.tag == "hand")
            {
                if (transform.position.z <= -0.59 && transform.position.z >= -0.614)
                {
                    ScoreManager.Score = ScoreManager.Score + 5 * ComboManager.ComboPonit;
                    Instantiate(particle, this.transform.position, particle.transform.rotation);
                    ComboManager.Combo = ComboManager.Combo + 1;
                    Destroy(this.gameObject);

                }
                if (transform.position.z <= -0.615 && transform.position.z >= -0.63)
                {
                    ScoreManager.Score = ScoreManager.Score + 15 * ComboManager.ComboPonit;
                    Instantiate(particle2, this.transform.position, particle.transform.rotation);
                    ComboManager.Combo = ComboManager.Combo + 1;
                    Destroy(this.gameObject);


                }
                if (transform.position.z <= -0.631 && transform.position.z >= -0.72)
                {
                    ScoreManager.Score = ScoreManager.Score + 3 * ComboManager.ComboPonit;
                    Instantiate(particle, this.transform.position, particle.transform.rotation);
                    ComboManager.Combo = ComboManager.Combo + 1;
                    Destroy(this.gameObject);

                }

            }
        }
     
    }


}