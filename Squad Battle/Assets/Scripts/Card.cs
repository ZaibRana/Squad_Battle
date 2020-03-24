using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public string description;
    public Sprite artwork;
    public int Tier = 1;

    public string group;
    public float strength;    //Attack
    public float defence;
    public float cutness;
    public float fear;
    public float totalvalue;


    private void OnValidate()
    {
        cardName = this.name;
        totalvalue = strength + defence + cutness + fear;
    }

}
