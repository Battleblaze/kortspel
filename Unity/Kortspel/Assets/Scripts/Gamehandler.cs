using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamehandler : MonoBehaviour {
    public Text canvasTexthp;
    public Text canvasTextRunda;
    public Text canvasTexthp2;
    public Text SkitigStyrka;

   
   public static bool runda;
   public static int lpPlayer1 = 2500;
    public static int lpPlayer2 = 2500;

    public static int SkitigtTroll = 500;
   


    // Use this for initialization
    void Start () {
        runda = true;
        NewGame();
    }
	
	// Update is called once per frame
	void Update () {
        SkitigStyrka.text = "atk: " + Kort.atk;
        canvasTexthp.text = "Hälsopoäng: " + lpPlayer1;
        canvasTexthp2.text = "Hälsopoäng: " + lpPlayer2;
        if (runda == true)
        {
            canvasTextRunda.text = "Avsluta Rundan";
        }
        if(runda == false)
        {
            canvasTextRunda.text = "Fiendens runda";
        }
    }

    void NewGame()
    {
        Kort.KanAnfalla = true;
        runda = true;
        canvasTexthp.text = "Hälsopoäng: " + lpPlayer1;
        canvasTexthp2.text = "Hälsopoäng: " + lpPlayer2;
        if (runda == true)
        {
            canvasTextRunda.text = "Avsluta Rundan";
        }
        else
        {
            canvasTextRunda.text = "Fiendens runda";
        }
    }
}
