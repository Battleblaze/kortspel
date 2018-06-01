using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menyn : MonoBehaviour {

    //Det här scriptet fixar menyn

    public void StartaSpel(string startaSpel)
    {
        SceneManager.LoadScene(2);
    }

    public void StartaLekByggaren(string bygga)
    {
        SceneManager.LoadScene(1);
    }
}
