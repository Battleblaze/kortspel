using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Kortlek : MonoBehaviour, IPointerClickHandler {
    public GameObject hand;

    public GameObject skitigtTroll;
    public GameObject trollensPower;
    public GameObject ondNattDrake;

    int i = 0;

    List<GameObject> kortlek = new List<GameObject>();

    // Use this for initialization
    public void Start () {

    hand = GameObject.Find("Hand");

        kortlek.Add(skitigtTroll);
        kortlek.Add(trollensPower);
        kortlek.Add(ondNattDrake);

    }
	
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Klickad");

        GameObject kort2 = Instantiate(kortlek[i]);
        kort2.transform.parent = hand.transform;
        i++;
    }

}
