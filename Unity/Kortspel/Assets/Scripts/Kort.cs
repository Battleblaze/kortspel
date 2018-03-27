using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kort : MonoBehaviour {
   public GameObject stZoom;
   public GameObject spawner;
    public bool spawned = false;

    void OnMouseOver()
    {
        Debug.Log("Jahopp");
        if (spawned == false)
        {
            Instantiate(gameObject, spawner.transform);
            spawned = true;
        }
    }
}
