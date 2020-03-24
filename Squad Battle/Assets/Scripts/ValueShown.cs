using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueShown : MonoBehaviour
{
    private bool check;

    private void Start()
    {
        check = true;
    }

    private void OnMouseOver()
    {
        for (int i = 0; i < AllCards.instance.cards.Length; i++)
        {
            if (AllCards.instance.cards[i].artwork == this.GetComponent<Image>().sprite && check == true && this.transform.GetChild(3).gameObject.activeInHierarchy == false && AllCards.instance.cards[i].Tier == 1)
            {

                //if find child star is active then choose value of tier2 else this

                this.transform.GetChild(0).gameObject.SetActive(true);
                this.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                    "Strenght = " + AllCards.instance.cards[i].strength + "\nDefense = " + AllCards.instance.cards[i].defence
                    + "\nCutness = " + AllCards.instance.cards[i].cutness + "\nFear = " + AllCards.instance.cards[i].fear;
                check = false;

            }

            if (AllCards.instance.cards[i].artwork == this.GetComponent<Image>().sprite && check == true && this.transform.GetChild(3).gameObject.activeInHierarchy == true && AllCards.instance.cards[i].Tier == 2)
            {

                //if find child star is active then choose value of tier2 else this

                this.transform.GetChild(0).gameObject.SetActive(true);
                this.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text =
                    "Strenght = " + AllCards.instance.cards[i].strength + "\nDefense = " + AllCards.instance.cards[i].defence
                    + "\nCutness = " + AllCards.instance.cards[i].cutness + "\nFear = " + AllCards.instance.cards[i].fear;
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
