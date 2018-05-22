using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiendeKortLek : MonoBehaviour {
    public GameObject hand2;
    public GameObject spelPlan2;
    public GameObject child;


    public GameObject skitigtTroll;
    public GameObject trollensPower;
    public GameObject ondNattDrake;

    int i = 4;

    public static bool fiendeFårDra = false;

    List<GameObject> kortlek = new List<GameObject>();
    // Use this for initialization
    void Start () {
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);



        for (int i = 0; i < 4; i++)
        {

            GameObject kort2 = Instantiate(kortlek[i]);
            kort2.transform.parent = hand2.transform;

        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Gamehandler.runda == false)
        {

            if (fiendeFårDra == true)
            {
                GameObject kort2 = Instantiate(kortlek[i]);
                kort2.transform.parent = hand2.transform;
                i++;
                fiendeFårDra = false;
            }

            if (Gamehandler.kanLäggaUt2 == true)
            {
                child = hand2.gameObject.transform.GetChild(0).gameObject;
                child.transform.parent = spelPlan2.transform;

                Gamehandler.kanLäggaUt2 = false;

                Gamehandler.runda = true;
                Kortlek.duFårDra = true;
            }

            
        }
    }
}
