using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlacementSection : MonoBehaviour
{
    public Image Sideboard1, Sideboard2, Sideboard3, Sideboard4, Sideboard5, Sideboard6;

    public Card[] cards;

    List<Card> cardsList = new List<Card>();

    //string selectedCard1, selectedCard2, selectedCard3, selectedCard4, selectedCard5;

    private void Start()
    {
        FetchCards();
        PreviewCards();
    }

    void PreviewCards()
    {
        if (cardsList[0] != null)
        {
            Sideboard1.gameObject.SetActive(true);
            Sideboard1.sprite = cardsList[0].artwork;
        }
        if (cardsList[1] != null)
        {
            Sideboard2.gameObject.SetActive(true);
            Sideboard2.sprite = cardsList[1].artwork;
        }
        if (cardsList[2] != null)
        {
            Sideboard3.gameObject.SetActive(true);
            Sideboard3.sprite = cardsList[2].artwork;
        }
        //if (cardsList[3] != null)
        //{
        //    Sideboard4.gameObject.SetActive(true);
        //    Sideboard4.sprite = cardsList[3].artwork;
        //}
        //if (cardsList[4] != null)
        //{
        //    Sideboard5.gameObject.SetActive(true);
        //    Sideboard5.sprite = cardsList[4].artwork;
        //}
        //if (cardsList[5] != null)
        //{
        //    Sideboard6.gameObject.SetActive(true);
        //    Sideboard6.sprite = cardsList[5].artwork;
        //}
    }

    void FetchCards()
    {
        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i].cardName == GameConstant.selectedCard1)
            {
                cardsList.Add(cards[i]);
            }
            if (cards[i].cardName == GameConstant.selectedCard2)
            {
                cardsList.Add(cards[i]);
            }
            if (cards[i].cardName == GameConstant.selectedCard3)
            {
                cardsList.Add(cards[i]);
            }
            if (cards[i].cardName == GameConstant.selectedCard4)
            {
                cardsList.Add(cards[i]);
            }
            if (cards[i].cardName == GameConstant.selectedCard5)
            {
                cardsList.Add(cards[i]);
            }

        }
    }
}
