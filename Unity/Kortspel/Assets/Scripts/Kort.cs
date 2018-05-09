using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Kort : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
   public GameObject spawner;
    public bool spawned = false;
    public int atk;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (spawned == false)
        {

           Instantiate(gameObject.GetComponent<Image>(), spawner.transform);
           

            spawned = true;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        spawned = false;
    }

}
