using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiendeKortLek : MonoBehaviour {
    public GameObject hand2;
    public GameObject hand3;
    public GameObject spelPlan2;
    public GameObject spelPlan;
    public GameObject child;

    GameObject kort3;
   
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

    public GameObject baksida;

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
        kortlek.Add(tigerthot);
        kortlek.Add(tanten);
        kortlek.Add(kaktus);
        kortlek.Add(kaktus);
        kortlek.Add(pyramid);
        kortlek.Add(downfågel);
        kortlek.Add(bevingatskit);
        kortlek.Add(ralph);
        kortlek.Add(trollkunen);
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



        for (int i = 0; i < 4; i++)
        {
            int korttabort = Random.Range(0, kortlek.Count);
            GameObject kort2 = Instantiate(kortlek[korttabort]);
            kortlek.RemoveAt(korttabort);

            kort2.transform.parent = hand2.transform;

            GameObject kort3 = Instantiate(baksida);
            kort3.transform.parent = hand3.transform;

        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Gamehandler.runda == false)
        {

            if (fiendeFårDra == true)
            {
                int korttabort = Random.Range(0, kortlek.Count);
                GameObject kort2 = Instantiate(kortlek[korttabort]);
                kortlek.RemoveAt(korttabort);


                kort2.transform.parent = hand2.transform;
                i++;

                kort3 = Instantiate(baksida);
                kort3.transform.parent = hand3.transform;

                fiendeFårDra = false;


            }

            if (Gamehandler.kanLäggaUt2 == true)
            {
                child = hand2.gameObject.transform.GetChild(0).gameObject;
                child.transform.parent = spelPlan2.transform;

                Destroy(kort3);

                GameObject strid = spelPlan2.gameObject.transform.GetChild(Random.Range(0, 3)).gameObject;
                GameObject strid2 = spelPlan.gameObject.transform.GetChild(0).gameObject;

                // Här kommer fiendens attak mot spelaren, den kollar efter det nått barn på fiendens sida och attakerar mot spelarens första kort på spelarens spelplan
                // Om det inte finns några kort att attakera så dras attaken mot spelarens livspoäng direkt
                // 

                if (spelPlan2.gameObject.transform.GetChild(3) != null)
                {
                    if (strid.GetComponent<Kort>().atk > strid2.GetComponent<Kort>().atk)
                    {
                        Destroy(strid2);

                        GameObject.Find("Killfeed").GetComponent<Text>().text = strid.name +" Dödade " + strid2.name;

                        GameObject.Find("Oof").GetComponent<AudioSource>().enabled = true;

                        Gamehandler.lpPlayer1 -= strid.GetComponent<Kort>().atk - strid2.GetComponent<Kort>().atk;
                    }

                   

                    if (strid.GetComponent<Kort>().atk == strid2.GetComponent<Kort>().atk)
                    {
                        Destroy(strid2);
                        Destroy(strid);
                        GameObject.Find("Killfeed").GetComponent<Text>().text = strid.name + " och " + strid2.name + "Dog i striden";
                        GameObject.Find("Oof").GetComponent<AudioSource>().enabled = true;
                    }
                    
                }
                


                Gamehandler.kanLäggaUt2 = false;

                Gamehandler.runda = true;
                Kortlek.duFårDra = true;
            }
           
            
        }
    }
}
