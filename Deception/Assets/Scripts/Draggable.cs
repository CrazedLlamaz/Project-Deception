using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentToReturnTo = null;

    public bool canBeDragged;
    public bool inCombat;

    GameController gameController;

    GameObject attackedCard;
    CardContents attackedCardContents;

    public void Start()
    {
        gameController = GameObject.Find("/GameController").GetComponent<GameController>();
    }

    public void OnBeginDrag(PointerEventData pointerEventData)
    {
        //Debug.Log("On Begin Drag");
        if(gameController.combatPhase)
        {
            GameObject attackingCard = this.gameObject;
            parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
        else if (gameController.summoningPhase)
        {
parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
        
    }

    public void OnDrag (PointerEventData pointerEventData)
    {
        //Debug.Log("On Drag");

        this.transform.position = pointerEventData.position;
    }

    public void OnEndDrag(PointerEventData pointerEventData)
    {
        //Debug.Log("On End Drag");
        if(gameController.combatPhase)
        {
            attackedCard = pointerEventData.pointerCurrentRaycast.gameObject;
            attackedCardContents = attackedCard.GetComponent<CardContents>();
            attackedCardContents.healthValue -= this.GetComponent<CardContents>().attackValue;
            this.GetComponent<CardContents>().hasAttacked = false;
            if(attackedCardContents.healthValue < 0)
            {
                attackedCardContents.healthValue = 0;
            }
        }
        this.transform.SetParent(parentToReturnTo);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

}
