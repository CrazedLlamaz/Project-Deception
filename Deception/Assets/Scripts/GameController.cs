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

            BuildDeck();

            Debug.Log("Match Start");
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

    public List<string> BuildDeck()
    {
        List<string> newDeck = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            newDeck.Add(deckContents[0]);

            Debug.Log("Card Added");
        }

        Debug.Log("Deck Built");

        matchStart = false;
        drawPhase = true;

        return newDeck;
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
