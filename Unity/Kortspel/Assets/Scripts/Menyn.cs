using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menyn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartaSpel(string startaSpel)
    {
        SceneManager.LoadScene(2);
    }

    public void StartaLekByggaren(string bygga)
    {
        SceneManager.LoadScene(1);
    }
}
