using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentToReturnTo = null;

    public void OnBeginDrag(PointerEventData pointerEventData)
    {
        //Debug.Log("On Begin Drag");

        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag (PointerEventData pointerEventData)
    {
        //Debug.Log("On Drag");

        this.transform.position = pointerEventData.position;
    }

    public void OnEndDrag(PointerEventData pointerEventData)
    {
        //Debug.Log("On End Drag");
        this.transform.SetParent(parentToReturnTo);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
