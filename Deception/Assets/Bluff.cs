using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bluff : MonoBehaviour
{
    public bool honest;
    GameObject bluffedCard;
    GameObject bluffContextMenu;

    public void BluffStart()
    {
        bluffContextMenu = gameObject.FindObjectWithTag("BluffContextUI");
        bluffedCard = gameObject.FindObjectWithTag("BluffedCard");
        honest = bluffedCard.GetComponent<CardScript>().bluffValue;

        Time.timeScale = 0;


    }
}
