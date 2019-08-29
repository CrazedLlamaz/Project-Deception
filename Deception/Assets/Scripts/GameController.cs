using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    bool matchStart;
    bool drawPhase;
    bool summoningPhase;
    bool spellPhase;
    bool combatPhase;
    bool endTurn;
    bool playerTurn;
    bool firstTurn; 
    bool coinFlip;
    bool coinFlipped;

    public string[] deckContents = new string[] {"Chicken", "Valiant Knight", "Goblin", "Wizard", "Dog", "Big Bad"};

    //public CardContainer[] cards;

    //public CardContainer[] cards;
    public GameObject[] cardPrefabs;

    public List<string> playerDeck;
    public List<string> enemyDeck;
    // Start is called before the first frame update
    void Start()
    {
        matchStart = true;
        firstTurn = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(matchStart)
        {
            
            if(!coinFlipped)
            {
                CoinFlip();
            }

            playerDeck = BuildDeck();
            Shuffle(playerDeck);

            enemyDeck = BuildDeck();
            Shuffle(enemyDeck);

            foreach (string card in playerDeck)
            {
                print(card);
            }

            Debug.Log("Match Start");

            Draw();
        }
        
        if (drawPhase)
        {
            DrawPhase();
        }

        if (summoningPhase)
        {
            SummoningPhase();
        }

        if (spellPhase)
        {
            SpellPhase();
        }

        if (combatPhase)
        {
            CombatPhase();
        }

        if (endTurn)
        {
            EndTurn();
        }
    }

    void Shuffle<T>(List<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }

    public List<string> BuildDeck()
    {
        List<string> newDeck = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            newDeck.Add(deckContents[0]);
            newDeck.Add(deckContents[1]);

            Debug.Log("Card Added");
        }

        Debug.Log("Deck Built");

        Debug.Log(newDeck);

        matchStart = false;
        drawPhase = true;

        return newDeck;
    }

    public void Draw()
    {
        if(playerTurn)
        {
            foreach(string card in playerDeck)
            {
                if( card == cardPrefabs[0].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[0], transform.position, Quaternion.identity, GameObject.Find("/Canvas/PlayerHand").transform);
                    newCard.name = card;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //newCard.transform.SetParent(GameObject.Find("/Canvas/PlayerHand").transform);
                }
                else if (card == cardPrefabs[1].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[1], transform.position, Quaternion.identity, GameObject.Find("/Canvas/PlayerHand").transform);
                    newCard.name = card;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //newCard.transform.SetParent(GameObject.Find("/Canvas/PlayerHand").transform);
                }
                
            }
        }
        else
        {
            foreach(string card in enemyDeck)
            {
                if( card == cardPrefabs[0].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[0], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = card;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.enemyCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    newCard.transform.GetChild(5).gameObject.SetActive(true);
                    //newCard.transform.SetParent(GameObject.Find("/Canvas/EnemyHand").transform);
                }
                else if (card == cardPrefabs[1].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[1], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = card;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.enemyCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    newCard.transform.GetChild(5).gameObject.SetActive(true);
                    //newCard.transform.SetParent(GameObject.Find("/Canvas/EnemyHand").transform);
                }
                
            }
        }
    }

    void CoinFlip()
    {
        coinFlip = (Random.value > 0.5f);
        if (coinFlip)
        {
            //play Heads coin flip animation
            playerTurn = true;
            Debug.Log("Player goes first");
        }
        else
        {
            //play Tails coin flip animation
            Debug.Log("Enemy goes first");
        }
        coinFlipped = true;
        

        Debug.Log("Coin Flipped");
    }

    void DrawPhase()
    {
        if(firstTurn)
        {
            for(int itwo = 0; itwo < 5; itwo++)
            {
                //Instantiate(playerCard, playerHand);
                //Instantiate(enemyCard, enemyHand);
                itwo++;
            }
        }
        else
        {
            if(playerTurn)
            {
                //Instantiate(playerCard, playerHand);
            }
            else
            {
                //Instantiate(enemyCard, enemyHand);
            }
        }
        drawPhase = false;
        summoningPhase = true;
        
    }

    void SummoningPhase()
    {

    }

    void SpellPhase()
    {

    }

    void CombatPhase()
    {

    }

    void EndTurn()
    {

    }
}
