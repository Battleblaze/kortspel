using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Motståndare : MonoBehaviour, IDropHandler
{

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + " släpptes på " + gameObject.name);

        Dra d = eventData.pointerDrag.GetComponent<Dra>();
        Kort k = eventData.pointerDrag.GetComponent<Kort>();

        Gamehandler.lpPlayer2 -= k.atk;
            
       
    }
}