using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Kortlek : MonoBehaviour {
    public GameObject hand;

    public GameObject skitigtTroll;
    public GameObject trollensPower;
    public GameObject ondNattDrake;

    int i = 4;
    int delay = 0;
    bool startHand = false;
   public static bool duFårDra = false;

    List<GameObject> kortlek = new List<GameObject>();

    // Use this for initialization
    public void Start () {

    hand = GameObject.Find("Hand");

        kortlek.Add(skitigtTroll);
        kortlek.Add(trollensPower);
        kortlek.Add(ondNattDrake);
        kortlek.Add(ondNattDrake);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);


        for (int i = 0; i < 4; i++)
        {

            GameObject kort2 = Instantiate(kortlek[i]);
            kort2.transform.parent = hand.transform;

        }
    }

    public void Update()
    {
        if (Gamehandler.runda == true)
        {
            
            if(duFårDra == true)
            {
                
                GameObject kort2 = Instantiate(kortlek[i]);
                kort2.transform.parent = hand.transform;
                i++;
                duFårDra = false;
            }
        }
    }


}
