using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrMusic : MonoBehaviour
{
    public AudioSource Audio;
    public bool Music;
    void Update()
    {
        if(Music){
          Audio.mute = !GameObject.FindGameObjectWithTag("Holder").GetComponent<ScrHolder>().Music;
        }
        else{
          Audio.mute = !GameObject.FindGameObjectWithTag("Holder").GetComponent<ScrHolder>().AFX;
        }
    }
}
