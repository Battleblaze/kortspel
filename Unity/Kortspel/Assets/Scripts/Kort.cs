using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Kort : MonoBehaviour {
   public GameObject spawner;
    public bool spawned = false;
    public int atk;


    




    void OnMouseOver()
    {
        Debug.Log("Jahopp");
        if (spawned == false)
        {

            spawner.transform.Find("GameObject").GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<SpriteRenderer>().sprite;

            spawned = true;         
        }
    }

    private void OnMouseExit()
    {
        spawned = false;
    }

}
