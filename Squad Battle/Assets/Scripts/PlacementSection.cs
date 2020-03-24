using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlacementSection : MonoBehaviour
{
    public Image Sideboard1, Sideboard2, Sideboard3, Sideboard4, Sideboard5, Sideboard6;

    private void Start()
    {
        FetchCards();
        PreviewCards();
    }


    void FetchCards()
    {
        for (int i = 0; i < AllCards.instance.cards.Length; i++)
        {
            if (AllCards.instance.cards[i].cardName == GameConstant.selectedCard1)
            {
                GameConstant.battleCardsList.Add(AllCards.instance.cards[i]);
            }
            if (AllCards.instance.cards[i].cardName == GameConstant.selectedCard2)
            {
                GameConstant.battleCardsList.Add(AllCards.instance.cards[i]);
            }
            if (AllCards.instance.cards[i].cardName == GameConstant.selectedCard3)
            {
                GameConstant.battleCardsList.Add(AllCards.instance.cards[i]);
            }
            if (AllCards.instance.cards[i].cardName == GameConstant.selectedCard4)
            {
                GameConstant.battleCardsList.Add(AllCards.instance.cards[i]);
            }
            if (AllCards.instance.cards[i].cardName == GameConstant.selectedCard5)
            {
                GameConstant.battleCardsList.Add(AllCards.instance.cards[i]);
            }
        }
    }

    void PreviewCards()
    {
        if (GameConstant.battleCardsList[0] != null)
        {
            Sideboard1.gameObject.SetActive(true);
            Sideboard1.sprite = GameConstant.battleCardsList[0].artwork;
        }
        if (GameConstant.battleCardsList[1] != null)
        {
            Sideboard2.gameObject.SetActive(true);
            Sideboard2.sprite = GameConstant.battleCardsList[1].artwork;
        }
        if (GameConstant.battleCardsList[2] != null)
        {
            Sideboard3.gameObject.SetActive(true);
            Sideboard3.sprite = GameConstant.battleCardsList[2].artwork;
        }
        //if (GameConstant.battleCardsList[3] != null)
        //{
        //    Sideboard4.gameObject.SetActive(true);
        //    Sideboard4.sprite = GameConstant.battleCardsList[3].artwork;
        //}
        //if (GameConstant.battleCardsList[4] != null)
        //{
        //    Sideboard5.gameObject.SetActive(true);
        //    Sideboard5.sprite = GameConstant.battleCardsList[4].artwork;
        //}
        //if (GameConstant.battleCardsList[5] != null)
        //{
        //    Sideboard6.gameObject.SetActive(true);
        //    Sideboard6.sprite = GameConstant.battleCardsList[5].artwork;
        //}
    }
}
