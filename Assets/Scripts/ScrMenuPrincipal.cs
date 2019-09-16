using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScrMenuPrincipal : MonoBehaviour
{   
    public GameObject MenuPrincipal;
    public GameObject MenuConfiguracoes;

    public void StarButton(){
        SceneManager.LoadScene("Jogo");
    }

    public void SettingsButton(){
        MenuConfiguracoes.SetActive(true);
        MenuPrincipal.SetActive(false);
    }

    public void QuitButton(){
        
    }
}
