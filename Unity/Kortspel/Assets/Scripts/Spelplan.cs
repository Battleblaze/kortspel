using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Spelplan : MonoBehaviour, IDropHandler {
    //Detta script ligger på en panel

    public void OnDrop(PointerEventData eventData) //Om nånting (Ett kort) droppas så sätts kortets förelder till detta gameobject
                                                    // vilket resulterar i att man flyttat ett kort från en panel till en annan
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
