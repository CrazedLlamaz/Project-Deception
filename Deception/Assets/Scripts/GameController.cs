using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    /* bool matchStart;
    bool drawPhase;
    bool summoningPhase;
    bool spellPhase;
    bool combatPhase;
    bool endTurn;
    bool playerTurn;
    bool firstTurn; 
    bool matchStart;
    bool coinFlip;
    
    // Start is called before the first frame update
    void Start()
    {
        matchStart = true;
        firstTurn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(matchStart)
        {
            CoinFlip();
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

    CoinFlip()
    {
        coinFlip = (Random.value > 0.5f);
        if (coinFlip)
        {
            //play Heads coin flip animation
            playerTurn = true;
        }
        else
        {
            //play Tails coin flip animation
        }
        matchStart = false;
        drawPhase = true;
    }

    DrawPhase()
    {
        if(firstTurn)
        {
            for(int i = 0; i < 5; i++)
            {
                Instantiate(playerCard, playerHand);
                Instantiate(enemyCard, enemyHand);
                i++;
            }
        }
        else
        {
            if(playerTurn)
            {
                Instantiate(playerCard, playerHand);
            }
            else
            {
                Instantiate(enemyCard, enemyHand);
            }
        }
        drawPhase = false;
        summoningPhase = true;
        
    }

    SummoningPhase()
    {

    }

    SpellPhase()
    {

    }

    CombatPhase()
    {

    }

    EndTurn()
    {

    }*/
}
