using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rundknapp : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void clickediclick(string clickclick)
    {
       
       
            Gamehandler.runda = false;
        FiendeKortLek.fiendeFårDra = true;
        
    }
}
