using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamehandler : MonoBehaviour {
    public Text canvasTexthp;
    public Text canvasTextRunda;
    public Text canvasTexthp2;

   public static bool runda;
    int lpPlayer1 = 2500;
    int lpPlayer2 = 2500;
    // Use this for initialization
    void Start () {
        runda = true;
    }
	
	// Update is called once per frame
	void Update () {
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
        Debug.Log(runda);
    }

    void NewGame()
    {
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
