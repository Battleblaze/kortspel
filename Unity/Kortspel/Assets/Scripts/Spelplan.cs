using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Spelplan : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + " släpptes på " + gameObject.name);

        Dra d = eventData.pointerDrag.GetComponent<Dra>();
        if (d != null)
        {
            if (Gamehandler.kanLäggaUt == true)
            {
                d.ParentToReturnTo = this.transform;

                Gamehandler.kanLäggaUt = false;
            }
        }

    }
}
