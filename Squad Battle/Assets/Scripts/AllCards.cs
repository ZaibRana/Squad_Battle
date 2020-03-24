using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllCards : MonoBehaviour
{

    public Card[] cards;

    public static AllCards instance;

    private void Start()
    {
        instance = this;
    }

}
