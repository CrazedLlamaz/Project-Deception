using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckScript : MonoBehaviour
{
    public enum DeckType {EnemyDeck, PlayerDeck};
    public DeckType deckType;

    public static string[] deckContents = new string[] {"Chicken", "Valiant Knight", "Goblin", "Wizard", "Dog", "Big Bad"};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static List<string> BuildDeck()
    {
        List<string> newDeck = new List<string>();
        foreach (string deckContent in deckContents)
        {
            newDeck.Add(deckContent);
        }

        return newDeck;
    }
}
