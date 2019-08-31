using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardContainer : ScriptableObject
{
    public string cardName;
    public string description;

    public int attack;
    public int health;

    public Sprite artwork;
    
}
