using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Kortlek : MonoBehaviour, IPointerClickHandler {
    public GameObject hand;

    public static GameObject skitigtTroll;

    GameObject[] kortlek1 = new GameObject[10];

    //List<GameObject> lista = new GameObject();


    // Use this for initialization
    public void Start () {

    skitigtTroll = GameObject.Find("Kort").GetComponent<GameObject>();
    GameObject trollKun = GameObject.Find("");
     GameObject trollensPower = GameObject.Find("trollensPower");
    GameObject fågelnMedDowns = GameObject.Find("");
    GameObject bevingadeSkitTrollet = GameObject.Find("");
    GameObject trollensHemmaplan = GameObject.Find("");
    GameObject trollgrottansIngång = GameObject.Find("");

    hand = GameObject.Find("Hand");

        GameObject[] kortlek1 =
        {
            skitigtTroll,trollensPower,skitigtTroll,trollensPower,skitigtTroll,skitigtTroll,trollensPower,skitigtTroll,trollensPower,skitigtTroll,
            
        };

    }
	
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Klickad");
        GameObject kort2 = Instantiate(skitigtTroll);
        kort2.transform.parent = hand.transform;
    }

}
