using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerObject : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		if(isLocalPlayer == false)
        {
            return;
        }


        NetworkServer.Spawn(PlayerUnitPrefab);
	}

    public GameObject PlayerUnitPrefab;

	// Update is called once per frame
	void Update () {
		
	}
}
