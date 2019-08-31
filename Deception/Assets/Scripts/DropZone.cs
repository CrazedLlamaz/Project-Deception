using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public enum ZoneType {PlayerHand, PlayerField, EnemyHand, EnemyField, PlayerGraveyard, EnemyGraveyard, PlayerDeck, EnemyDeck};
    public ZoneType zoneType;

    public GameController gameController;

    public void OnDrop(PointerEventData pointerEventData)
    {
        Debug.Log("On Drop");

        Draggable draggable = pointerEventData.pointerDrag.GetComponent<Draggable>();
        CardContents cardContents = pointerEventData.pointerDrag.GetComponent<CardContents>();
        GameObject cardBack = pointerEventData.pointerDrag.transform.GetChild(5).gameObject;
        if(gameController.summoningPhase)
        {
            if(draggable != null && zoneType == ZoneType.PlayerField)
            {
                if(cardContents.playerCard == true && gameController.monsterSummoned == false)
                {
                draggable.parentToReturnTo = this.transform;
                gameController.monsterSummoned = true;
                }
            }
            else if (draggable != null && zoneType == ZoneType.EnemyField)
            {
                if(cardContents.enemyCard == true && gameController.monsterSummoned == false)
                {
                    draggable.parentToReturnTo = this.transform;
                    cardBack.SetActive(false);

                    gameController.monsterSummoned = true;
                }   
            }    
        }
    }
}
