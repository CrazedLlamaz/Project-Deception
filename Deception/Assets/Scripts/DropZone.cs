using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public enum ZoneType {PlayerHand, PlayerField, EnemyHand, EnemyField, PlayerGraveyard, EnemyGraveyard, PlayerDeck, EnemyDeck};
    public ZoneType zoneType;
    public void OnDrop(PointerEventData pointerEventData)
    {
        Debug.Log("On Drop");

        Draggable draggable = pointerEventData.pointerDrag.GetComponent<Draggable>();
        if(draggable != null)
        {
            draggable.parentToReturnTo = this.transform;
        }
    }
}
