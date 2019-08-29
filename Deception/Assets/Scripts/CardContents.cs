using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardContents : MonoBehaviour
{
    public CardContainer cardContainer;

    public TextMeshProUGUI nameText;
    //public TextMeshProUGUI descriptionText;

    public TextMeshProUGUI attackValue;
    public TextMeshProUGUI healthValue;

    public Image cardArtwork;

    public bool playerCard;
    public bool enemyCard;

    // Start is called before the first frame update
    void Start()
    {

        //nameText.text = cardContainer.cardName;

        //attackValue.text = cardContainer.attack.ToString();
        //healthValue.text = cardContainer.health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
