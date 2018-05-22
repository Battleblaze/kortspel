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

   public static int lpPlayer1 = 2500;
    public static int lpPlayer2 = 2500;

    public static int SkitigtTroll = 500;
   


    void Start () {
        runda = true;
        Kortlek.duFårDra = true;
        NewGame();
    }
	
	void Update () {
        canvasTexthp.text = "Hälsopoäng: " + lpPlayer1;
        canvasTexthp2.text = "Hälsopoäng: " + lpPlayer2;
        if (runda == true)
        {
            

            if (rundaStart == true)
            {
                kanLäggaUt = true;

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
