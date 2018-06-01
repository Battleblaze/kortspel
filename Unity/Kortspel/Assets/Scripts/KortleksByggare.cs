using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KortleksByggare : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject dinKortlek;

    //låter dig leka i en kortleksbyggare som är värdelös

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

        Instantiate(d, this.transform);

        

    }
}
