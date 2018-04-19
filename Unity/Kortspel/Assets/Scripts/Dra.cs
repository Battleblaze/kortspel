﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dra : MonoBehaviour, IBeginDragHandler,IDragHandler, IEndDragHandler {

    Transform ParentToReturnTo = null;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");

        ParentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.root);
    }

    public void OnDrag(PointerEventData eventData)
    {

        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent( ParentToReturnTo);
    }

}
