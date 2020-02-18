using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public string description;
    public Sprite artwork;

    public string group;
    public int strength;
    public int defence;
    public int cutness;
    public int fear;

    public int totalvalue;

    private void OnValidate()
    {
        cardName = this.name;
        totalvalue = strength + defence + cutness + fear;
    }

}
