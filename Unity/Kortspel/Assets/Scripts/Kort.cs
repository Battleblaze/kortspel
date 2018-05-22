using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Kort : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IDropHandler
{
   public GameObject spawner;
    public bool spawned = false;
    public int atk = 500;
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (spawned == false)
        {

           //Instantiate(gameObject.GetComponent<Image>(), spawner.transform);
           

            spawned = true;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        spawned = false;
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + " släpptes på " + gameObject.name);
        string namnet = eventData.pointerDrag.name;
        //int atk2 = Gamehandler.namnet;

        Kort k = eventData.pointerDrag.GetComponent<Kort>();
        Debug.Log(gameObject.GetComponent<Kort>().atk);
        if(k.atk == gameObject.GetComponent<Kort>().atk)
        {
            Destroy(gameObject);
            Destroy(Dra.kort);
        }
        if(k.atk > gameObject.GetComponent<Kort>().atk)
        {
            Destroy(gameObject);

            Gamehandler.lpPlayer2 -= k.atk - gameObject.GetComponent<Kort>().atk;
        }
        else
        {
            Destroy(Dra.kort);

            Gamehandler.lpPlayer1 -= k.atk - gameObject.GetComponent<Kort>().atk;
        }
       
            
        
    }

}
