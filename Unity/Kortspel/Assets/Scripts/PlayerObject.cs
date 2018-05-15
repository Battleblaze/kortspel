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


        CmdSpawnMyUnit();
	}

    public GameObject PlayerUnitPrefab;

	// Update is called once per frame
	void Update () {
		
	}

    [Command]
    void CmdSpawnMyUnit()
    {
        GameObject go = Instantiate(PlayerUnitPrefab);

        NetworkServer.Spawn(go);
    }
}
