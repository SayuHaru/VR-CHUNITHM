using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanntei : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    public Material ON;
    public Material OFF;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            audioSource.PlayOneShot(sound1);
            GetComponent<Renderer>().material.color = ON.color;
        }
            

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            GetComponent<Renderer>().material.color = OFF.color;
        }
    }



    }