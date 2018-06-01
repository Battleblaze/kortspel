using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiendeKortLek : MonoBehaviour {
    public GameObject hand2;
    public GameObject spelPlan2;
    public GameObject child;
    /// <summary>
    /// Det här scriptet innehåller Lite dålig AI och fiendens kortlek.
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

    public static bool fiendeFårDra = false;

    List<GameObject> kortlek = new List<GameObject>();
    // Use this for initialization
    void Start () {
        kortlek.Add(skitigtTroll);
        kortlek.Add(trollensPower);
        kortlek.Add(ondNattDrake);
        kortlek.Add(ondNattDrake);
        kortlek.Add(skitigtTroll);
<<<<<<< Updated upstream
        kortlek.Add(tigerthot);
        kortlek.Add(tanten);
        kortlek.Add(kaktus);
        kortlek.Add(kaktus);
        kortlek.Add(pyramid);
        kortlek.Add(downfågel);
        kortlek.Add(bevingatskit);
        kortlek.Add(ralph);
        kortlek.Add(trollkunen);
=======
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
        kortlek.Add(skitigtTroll);
>>>>>>> Stashed changes



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
