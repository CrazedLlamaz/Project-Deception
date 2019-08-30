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

    public string[] deckContents = new string[] {"Chicken", "Valiant Knight", "Brutus the Strong", "The Very Ancient Wizard", "Guardian of The Abyss"};

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

        playerDeck = BuildDeck();
        Shuffle(playerDeck);

        enemyDeck = BuildDeck();
        Shuffle(enemyDeck);

        FirstDraw();

        CoinFlip();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(matchStart)
        {
            
            if(!coinFlipped)
            {
                
            }

            //playerDeck = BuildDeck();
            //Shuffle(playerDeck);

            //enemyDeck = BuildDeck();
            //Shuffle(enemyDeck);

            Debug.Log("Match Start");

            //FirstDraw();
        }
        
        if (drawPhase)
        {
            //DrawPhase();
        }

        if (summoningPhase)
        {
            //SummoningPhase();
        }

        if (spellPhase)
        {
            //SpellPhase();
        }

        if (combatPhase)
        {
            //CombatPhase();
        }

        if (endTurn)
        {
            //EndTurn();
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
        for (int i = 0; i < 6; i++)
        {
            newDeck.Add(deckContents[0]);
            newDeck.Add(deckContents[1]);
            newDeck.Add(deckContents[2]);
            newDeck.Add(deckContents[3]);
            newDeck.Add(deckContents[4]);

            Debug.Log("Card Added");
        }

        Debug.Log("Deck Built");

        Debug.Log(newDeck);

        

        return newDeck;
    }

    public void FirstDraw()
    {
            int deckSize = playerDeck.Count - 1;
            Debug.Log(deckSize);
            
            for (int i = deckSize; i > (deckSize - 5);)
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
                    //playerDeck.Remove(playerDeck[i]);
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
                    //playerDeck.Remove(playerDeck[i]);
                }
                else if(playerDeck[i] == cardPrefabs[2].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[2], transform.position, Quaternion.identity, GameObject.Find("/Canvas/PlayerHand").transform);
                    newCard.name = cardPrefabs[2].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //playerDeck.Remove(playerDeck[i]);
                }
                else if(playerDeck[i] == cardPrefabs[3].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[3], transform.position, Quaternion.identity, GameObject.Find("/Canvas/PlayerHand").transform);
                    newCard.name = cardPrefabs[3].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //playerDeck.Remove(playerDeck[i]);
                }
                else if(playerDeck[i] == cardPrefabs[4].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[4], transform.position, Quaternion.identity, GameObject.Find("/Canvas/PlayerHand").transform);
                    newCard.name = cardPrefabs[4].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //playerDeck.Remove(playerDeck[i]);
                }

                playerDeck.RemoveAt(i);

                i--;
            }

            deckSize = enemyDeck.Count -1;
            Debug.Log(deckSize);

            for (int i = deckSize; i > (deckSize - 5);)
            {

                if(enemyDeck[i] == cardPrefabs[0].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[0], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = cardPrefabs[0].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //enemyDeck.Remove(enemyDeck[i]);
                    newCard.transform.GetChild(5).gameObject.SetActive(true);
                }
                else if(enemyDeck[i] == cardPrefabs[1].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[1], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = cardPrefabs[1].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //enemyDeck.Remove(enemyDeck[i]);
                    newCard.transform.GetChild(5).gameObject.SetActive(true);
                }
                else if(enemyDeck[i] == cardPrefabs[2].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[2], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = cardPrefabs[2].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //enemyDeck.Remove(enemyDeck[i]);
                    newCard.transform.GetChild(5).gameObject.SetActive(true);
                }
                else if(enemyDeck[i] == cardPrefabs[3].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[3], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = cardPrefabs[3].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //enemyDeck.Remove(enemyDeck[i]);
                    newCard.transform.GetChild(5).gameObject.SetActive(true);
                }
                else if(enemyDeck[i] == cardPrefabs[4].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[4], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = cardPrefabs[4].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //enemyDeck.Remove(enemyDeck[i]);
                    newCard.transform.GetChild(5).gameObject.SetActive(true);
                }

                

                enemyDeck.RemoveAt(i);

                i--;
            }

            matchStart = false;
            drawPhase = true;

            Debug.Log("Enemy Deck Size" + enemyDeck.Count);
            Debug.Log("Player Deck Size" + playerDeck.Count);
    }

    public void Draw()
    {
        
        if(playerTurn)
        {
            int i = playerDeck.Count - 1;
            Debug.Log(i);

            if(playerDeck[i] == cardPrefabs[0].name)

                

                {
                    GameObject newCard = Instantiate(cardPrefabs[0], transform.position, Quaternion.identity, GameObject.Find("/Canvas/PlayerHand").transform);
                    newCard.name = cardPrefabs[0].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    playerDeck.RemoveAt(i);
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
                    playerDeck.RemoveAt(i);
                }
                else if(playerDeck[i] == cardPrefabs[2].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[2], transform.position, Quaternion.identity, GameObject.Find("/Canvas/PlayerHand").transform);
                    newCard.name = cardPrefabs[2].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //playerDeck.Remove(playerDeck[i]);
                }
                else if(playerDeck[i] == cardPrefabs[3].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[3], transform.position, Quaternion.identity, GameObject.Find("/Canvas/PlayerHand").transform);
                    newCard.name = cardPrefabs[3].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //playerDeck.Remove(playerDeck[i]);
                }
                else if(playerDeck[i] == cardPrefabs[4].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[4], transform.position, Quaternion.identity, GameObject.Find("/Canvas/PlayerHand").transform);
                    newCard.name = cardPrefabs[4].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //playerDeck.Remove(playerDeck[i]);
                }
        }
        else
        {
            Debug.Log("Enemy Turn");
        }

        Debug.Log("Enemy Deck Size" + enemyDeck.Count);
        Debug.Log("Player Deck Size" + playerDeck.Count);
    }

    void EnemyDraw()
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
                    enemyDeck.RemoveAt(i);
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
                    enemyDeck.RemoveAt(i);
                }
                else if(enemyDeck[i] == cardPrefabs[2].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[2], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = cardPrefabs[2].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //enemyDeck.Remove(enemyDeck[i]);
                    newCard.transform.GetChild(5).gameObject.SetActive(true);
                }
                else if(enemyDeck[i] == cardPrefabs[3].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[3], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = cardPrefabs[3].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //enemyDeck.Remove(enemyDeck[i]);
                    newCard.transform.GetChild(5).gameObject.SetActive(true);
                }
                else if(enemyDeck[i] == cardPrefabs[4].name)
                {
                    GameObject newCard = Instantiate(cardPrefabs[4], transform.position, Quaternion.identity, GameObject.Find("/Canvas/EnemyHand").transform);
                    newCard.name = cardPrefabs[4].name;
                    CardContents newCardContents = newCard.GetComponent<CardContents>();
                    newCardContents.playerCard = true;
                    newCardContents.nameText.text = newCardContents.cardContainer.cardName;
                    newCardContents.attackValue.text = newCardContents.cardContainer.attack.ToString();
                    newCardContents.healthValue.text = newCardContents.cardContainer.health.ToString();
                    //enemyDeck.Remove(enemyDeck[i]);
                    newCard.transform.GetChild(5).gameObject.SetActive(true);
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
}
