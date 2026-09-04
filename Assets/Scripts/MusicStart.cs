using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStart : MonoBehaviour
{

    public AudioSource Music;

    // Start is called before the first frame update
    void Start()
    {
        Music = GetComponent<AudioSource>();
        Invoke("playAudio", 15.0f);

     }

    // Update is called once per frame
    void Update()
    {
        
    }

   void playAudio()
    {
        Music.Play();
    }



}
