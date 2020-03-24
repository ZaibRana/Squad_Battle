using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueShown : MonoBehaviour
{

    public Card[] cards;
    private bool check;

    private void Start()
    {
        check = true;
    }

    private void OnMouseOver()
    {
        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i].artwork == this.GetComponent<Image>().sprite && check == true)
            {
                this.transform.GetChild(0).gameObject.SetActive(true);
                this.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                    "Strenght = " + cards[i].strength + "\nDefense = " + cards[i].defence
                    + "\nCutness = " + cards[i].cutness + "\nFear = " + cards[i].fear;
                check = false;
            }
        }
    }

    private void OnMouseExit()
    {
        check = true;
        this.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "";
        this.transform.GetChild(0).gameObject.SetActive(false);
    }

}
