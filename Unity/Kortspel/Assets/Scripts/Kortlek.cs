using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Kortlek : MonoBehaviour {
    public GameObject hand;

    /// <summary>
    /// Det här scriptet innehåller våran kortlek och dra kort grejen
    /// </summary>
    public GameObject skitigtTroll;
    public GameObject trollensPower;
    public GameObject ondNattDrake;
    public GameObject tanten;
    public GameObject ralph;
    public GameObject downfågel;
    public GameObject bevingatskit;
    public GameObject trollkunen;
    public GameObject kaktus;
    public GameObject pyramid;
    public GameObject tigerthot;
    

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
        kortlek.Add(tigerthot);
        kortlek.Add(tanten);
        kortlek.Add(kaktus);
        kortlek.Add(kaktus);
        kortlek.Add(pyramid);
        kortlek.Add(downfågel);
        kortlek.Add(bevingatskit);
        kortlek.Add(ralph);
        kortlek.Add(trollkunen);



        for (int i = 0; i < 4; i++) //Här kommer din starthand att dras
        {
            int korttabort = Random.Range(0, kortlek.Count);
            GameObject kort2 = Instantiate(kortlek[korttabort]);
            kortlek.RemoveAt(korttabort);

            kort2.transform.parent = hand.transform;

        }
    }

    public void Update()
    {
        if (Gamehandler.runda == true) //här kommer ett kort att dras till din hand í början av varje runda
        {
            
            if(duFårDra == true)
            {
                int korttabort = Random.Range(0, kortlek.Count);
                GameObject kort2 = Instantiate(kortlek[korttabort]);
                kortlek.RemoveAt(korttabort);

                kort2.transform.parent = hand.transform;
                i++;
                duFårDra = false;
            }
        }
    }


}
