using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Kort : MonoBehaviour, IDropHandler
{
   public GameObject spawner;
    public bool spawned = false;
    public int atk = 500;
 


    public void OnDrop(PointerEventData eventData) //ondrop händer när nånting droppas på detta gameobject
    {
        Debug.Log(eventData.pointerDrag.name + " släpptes på " + gameObject.name);
        string namnet = eventData.pointerDrag.name;
        //int atk2 = Gamehandler.namnet;

        Kort k = eventData.pointerDrag.GetComponent<Kort>();
        Debug.Log(gameObject.GetComponent<Kort>().atk);

        if (Gamehandler.canAttakera == true)
        {

            if (k.atk == gameObject.GetComponent<Kort>().atk)       //dessa ifar kollar villet kort som gör mest skada och delar ut skador.
            {
                Destroy(gameObject);
                Destroy(Dra.kort);

                GameObject.Find("Killfeed").GetComponent<Text>().text = k.name + " och " + gameObject.GetComponent<Kort>().name + "dog"; 
                GameObject.Find("Oof").GetComponent<AudioSource>().enabled = true;
            }
            if (k.atk > gameObject.GetComponent<Kort>().atk)
            {
                Destroy(gameObject);

                GameObject.Find("Killfeed").GetComponent<Text>().text = k.name + " Dödade " + gameObject.GetComponent<Kort>().name;
                GameObject.Find("Oof").GetComponent<AudioSource>().enabled = true;

                Gamehandler.lpPlayer2 -= k.atk - gameObject.GetComponent<Kort>().atk;
            }
            else
            {
                Destroy(Dra.kort);

                GameObject.Find("Killfeed").GetComponent<Text>().text = gameObject.GetComponent<Kort>().name + " Dödade " + k.name;
                GameObject.Find("Oof").GetComponent<AudioSource>().enabled = true;

                Gamehandler.lpPlayer1 -= k.atk - gameObject.GetComponent<Kort>().atk;
            }

            Gamehandler.canAttakera = false;

        }
       
            
        
    }

}
