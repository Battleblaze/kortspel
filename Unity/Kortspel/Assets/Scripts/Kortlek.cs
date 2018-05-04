using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Kortlek : MonoBehaviour, IPointerClickHandler {
    public GameObject hand;

   public GameObject skitigtTroll = GameObject.Find("Kort");
    GameObject trollKun = GameObject.Find("");
    public GameObject trollensPower = GameObject.Find("trollensPower");
    GameObject fågelnMedDowns = GameObject.Find("");
    GameObject bevingadeSkitTrollet = GameObject.Find("");
    GameObject trollensHemmaplan = GameObject.Find("");
    GameObject trollgrottansIngång = GameObject.Find("");

    GameObject[] kortlek1;


    // Use this for initialization
    public void Start () {

        hand = GameObject.Find("Hand");

        GameObject[] kortlek1 =
        {
            skitigtTroll,trollensPower,skitigtTroll,trollensPower,skitigtTroll,skitigtTroll,trollensPower,skitigtTroll,trollensPower,skitigtTroll,
            skitigtTroll,trollensPower,skitigtTroll,trollensPower,skitigtTroll,skitigtTroll,trollensPower,skitigtTroll,trollensPower,skitigtTroll,
            skitigtTroll,trollensPower,skitigtTroll,trollensPower,skitigtTroll,skitigtTroll,trollensPower,skitigtTroll,trollensPower,skitigtTroll,
        };

        
        for (int i = 0; i < 4; i++)
        {
           
        }

	}
	
    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject kort2 = Instantiate( kortlek1[Random.Range(0, kortlek1.Length)] );
        kort2.transform.parent = hand.transform;
    }

}
