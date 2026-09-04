using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStart1 : MonoBehaviour
{

    public AudioSource Music1;

    // Start is called before the first frame update
    void Start()
    {
        Music1 = GetComponent<AudioSource>();
        Invoke("playAudio", 100.0f);

     }

    // Update is called once per frame
    void Update()
    {
        
    }

   void playAudio()
    {
        Music1.Play();
    }



}
