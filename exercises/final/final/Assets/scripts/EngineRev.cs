using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineRev : MonoBehaviour
{

    public AudioSource rev;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rev.Play();
        }
        
    }
}
