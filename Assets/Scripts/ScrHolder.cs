using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrHolder : MonoBehaviour
{
    public bool Music;
    public bool AFX;

    private void Start() {
        DontDestroyOnLoad(gameObject);
    }
}
