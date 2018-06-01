using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamehandler : MonoBehaviour {
    public Text canvasTexthp;
    public Text canvasTextRunda;
    public Text canvasTexthp2;
    public Text SkitigStyrka;
    public Text ondNattStyrka;


    public static bool runda;
    public static bool kanLäggaUt;
    public static bool kanLäggaUt2;
    bool rundaStart = true;

    public static bool canAttakera;

   public static int lpPlayer1 = 2500;
    public static int lpPlayer2 = 2500;

    public static int SkitigtTroll = 500;

    public static List<GameObject> kortPåPlanen = new List<GameObject>();

    void Start () {
        runda = true;
        Kortlek.duFårDra = true;

        GameObject.Find("Vinst").GetComponent<Text>().enabled = false;
        GameObject.Find("Förlust").GetComponent<Text>().enabled = false;
        NewGame();
    }
	
	void Update () {
        canvasTexthp.text = "Hälsopoäng: " + lpPlayer1;
        canvasTexthp2.text = "Hälsopoäng: " + lpPlayer2;


        if(lpPlayer1 <= 0)
        {
            GameObject.Find("Förlust").GetComponent<Text>().enabled = true;
            GameObject.Find("Musik").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("MusikLost").GetComponent<AudioSource>().enabled = true;
        }

        if (lpPlayer2 <= 0)
        {
            GameObject.Find("Vinst").GetComponent<Text>().enabled = true;
            GameObject.Find("Musik").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("MusikVinst").GetComponent<AudioSource>().enabled = true;
        }


        if (runda == true)
        {
            

            if (rundaStart == true)
            {
                kanLäggaUt = true;
                canAttakera = true;

                rundaStart = false;
            }

            canvasTextRunda.text = "Avsluta Rundan";
        }
        if(runda == false)
        {
            if (rundaStart == false)
            {
                kanLäggaUt2 = true;


                rundaStart = true;
            }

            canvasTextRunda.text = "Fiendens runda";
        }

    }

    void NewGame()
    {
        runda = true;
       
    }
}
