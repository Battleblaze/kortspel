using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KortZoom : MonoBehaviour {
    public GameObject stZoom;
    public GameObject spawner;

    void Start () {
        stZoom = GameObject.Find("Skitigt troll Zoom");
        spawner = GameObject.Find("spawner");

        Instantiate(stZoom, spawner.transform) ;
	}
	

	void Update () {
		
	}
}
