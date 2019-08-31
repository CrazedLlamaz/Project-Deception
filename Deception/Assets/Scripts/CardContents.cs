using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardContents : MonoBehaviour
{
    public CardContainer cardContainer;
    public GameController gameController;

    public TextMeshProUGUI nameText;
    //public TextMeshProUGUI descriptionText;

    public int attackValue;
    public int healthValue;

    public Sprite cardArtwork;
    public Sprite attackValueArtwork;
    public Sprite healthValueArtwork;
    public Sprite[] numericValues;
    public Sprite cardTemplate;
    public Sprite cardBack;

    public bool playerCard;
    public bool enemyCard;
    public bool hasAttacked;

    // Start is called before the first frame update
    void Start()
    {
        attackValueArtwork = numericValues[attackValue];
        healthValueArtwork = numericValues[healthValue];

        attackValue = cardContainer.attack;
        healthValue = cardContainer.health;

        //nameText.text = cardContainer.cardName;

        //attackValue.text = cardContainer.attack.ToString();
        //healthValue.text = cardContainer.health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        attackValueArtwork = numericValues[attackValue];
        healthValueArtwork = numericValues[healthValue];

        if(gameController.combatPhase == false)
        {
            hasAttacked = false;
        }
    }
}
