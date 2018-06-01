using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dra : MonoBehaviour, IBeginDragHandler,IDragHandler, IEndDragHandler {

    public Transform ParentToReturnTo = null;
    public static GameObject kort;
    /// <summary>
    /// Det här scriptet fixar så att han kan dra runt kort på skärmen och släppa dom på olika paneler.
    /// </summary>
    /// <param name="eventData"></param>

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");

        ParentToReturnTo = this.transform.parent;  //här sätt föreldern som kortet ska hoppa till om man släpper den utanför en tillåten panel
        this.transform.SetParent(this.transform.root);

        GetComponent<CanvasGroup>().blocksRaycasts = false;

        kort = transform.gameObject;
    }

    public void OnDrag(PointerEventData eventData)
    {

        this.transform.position = eventData.position;  //Kortets position blir samma som musens position i Ondrag funktionen
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(ParentToReturnTo);  //Händelsen häder om man släpper ett kort utanför de tillåtna panelera eller på en otillåten panel



        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

}
