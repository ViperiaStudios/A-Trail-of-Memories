using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectPickup : MonoBehaviour
{
    
   

    

    public GameObject Memory;

    public AudioSource Sound;
    
    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
            
    }

    
    

     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Sound.Play();
            Destroy(Memory);
        }
    }
}

