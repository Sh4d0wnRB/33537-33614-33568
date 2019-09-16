using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrMenuSettings : MonoBehaviour
{
    public GameObject Holder;
    public GameObject MenuSettings;
    public GameObject MenuPrincipal;
    public void Back(){
        MenuPrincipal.SetActive(true);
        MenuSettings.SetActive(false);
    }

    public void TurnMusic(bool OP){
        Holder.GetComponent<ScrHolder>().Music = OP;
    }

    public void TurnAFX(bool Turn){
        Holder.GetComponent<ScrHolder>().AFX = Turn;
    }
}
