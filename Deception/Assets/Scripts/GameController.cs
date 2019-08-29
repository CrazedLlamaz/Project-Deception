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

            FirstDraw();
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

    public void FirstDraw()
    {
        if(firstTurn)
        {
            int deckSize = playerDeck.Count - 1;
            
            for (int i = deckSize; i > (deckSize -= 5);)
            {
                if(playerDeck[i] == cardPrefabs[0].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[0], transform.position, Quaternion.identity, GameObject.Find("/Canvas/PlayerHand").transform);
                    newCard.name = cardPrefabs[0].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    playerDeck.Remove(playerDeck[i]);
                }
                else if(playerDeck[i] == cardPrefabs[1].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[1], transform.position, Quaternion.identity, GameObject.Find("/Canvas/PlayerHand").transform);
                    newCard.name = cardPrefabs[1].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    playerDeck.Remove(playerDeck[i]);
                }

                if(enemyDeck[i] == cardPrefabs[0].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[0], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = cardPrefabs[0].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.enemyCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    enemyDeck.Remove(enemyDeck[i]);
                }
                else if(enemyDeck[i] == cardPrefabs[1].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[1], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = cardPrefabs[1].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.enemyCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    enemyDeck.Remove(enemyDeck[i]);
                }


                
                i--;
            }

            Debug.Log("Enemy Deck Size" + enemyDeck.Count);
            Debug.Log("Player Deck Size" + playerDeck.Count);
        }
    }

    public void Draw()
    {
        
        if(playerTurn)
        {
            int i = playerDeck.Count;

            if(playerDeck[i] == cardPrefabs[0].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[0], transform.position, Quaternion.identity, GameObject.Find("/Canvas/PlayerHand").transform);
                    newCard.name = cardPrefabs[0].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    playerDeck.Remove(playerDeck[i]);
                }
                else if(playerDeck[i] == cardPrefabs[1].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[1], transform.position, Quaternion.identity, GameObject.Find("/Canvas/PlayerHand").transform);
                    newCard.name = cardPrefabs[1].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    playerDeck.Remove(playerDeck[i]);
                }
        }
        else
        {
            int i = enemyDeck.Count;

            if(enemyDeck[i] == cardPrefabs[0].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[0], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = cardPrefabs[0].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.enemyCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    enemyDeck.Remove(enemyDeck[i]);
                }
                else if(playerDeck[i] == cardPrefabs[1].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[1], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = cardPrefabs[1].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.enemyCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    enemyDeck.Remove(enemyDeck[i]);
                }
        }
        Debug.Log("Enemy Deck Size" + enemyDeck.Count);
        Debug.Log("Player Deck Size" + playerDeck.Count);
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
            drawPhase = false;
        }
        else
        {
            //make draw button functional
        }
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
