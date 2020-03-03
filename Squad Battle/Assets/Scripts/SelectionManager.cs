using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SelectionManager : MonoBehaviour
{
    //For Cards
    public Card[] cards;
    public Image card1, card2, card3, card4, card5;
    public int cardno1, cardno2, cardno3, cardno4, cardno5;
    List<int> list = new List<int>();
    public int cardsCanSelected = 3;
    private int cardsSelected = 0;

    //For Icons
    public Image Icon1, Icon2, Icon3, Icon4;
    public Sprite AnimalIcon, RobotIcon, PlantIcon, DinoIcon;
    List<string> listIcons = new List<string>();
    List<string> listGroupNames = new List<string>();
    private string groupname;
    private bool card1_OneClick = false, card2_OneClick = false, card3_OneClick = false,
        card4_OneClick = false, card5_OneClick = false;


    //Arrange, Shuffle and Assign Cards
    private void Start()
    {
        ArrangeCards();
        AssignCards();
    }

    //Canvas Button Card click function.
    public void ClickCard(int val)
    {
        if (cardsSelected < cardsCanSelected)
        {
            if (val == 1)
            {
                //For Select
                if (card1_OneClick == false)
                {
                    //For Icon
                    groupname = cards[cardno1].group;
                    listGroupNames.Add(groupname);
                    if (!listIcons.Contains(groupname))
                    {
                        listIcons.Add(groupname);
                        ShowIcon();
                    }

                    //For Card
                    card1.transform.GetChild(0).gameObject.SetActive(true);
                    card1.color = new Color32(255, 255, 255, 100);
                    cardsSelected++;
                    SelectCard(cardno1);
                    card1_OneClick = true;
                    return;
                }

                //For Deselect
                if (card1_OneClick == true)
                {
                    //For Icon
                    groupname = cards[cardno1].group;
                    if (listGroupNames.Contains(groupname))
                    {
                        listGroupNames.Remove(groupname);
                        if (!listGroupNames.Contains(groupname))
                        {
                            listIcons.Remove(groupname);
                            RemoveIcon();
                        }
                    }

                    //For Card
                    card1.transform.GetChild(0).gameObject.SetActive(false);
                    card1.color = new Color32(255, 255, 255, 255);
                    cardsSelected--;
                    DeSelectCard(cardno1);
                    card1_OneClick = false;
                    return;
                }
            }
            if (val == 2)
            {
                //For Select
                if (card2_OneClick == false)
                {
                    //For Icon
                    groupname = cards[cardno2].group;
                    listGroupNames.Add(groupname);
                    if (!listIcons.Contains(groupname))
                    {
                        listIcons.Add(groupname);
                        ShowIcon();
                    }

                    //For Card
                    card2.transform.GetChild(0).gameObject.SetActive(true);
                    card2.color = new Color32(255, 255, 255, 100);
                    cardsSelected++;
                    SelectCard(cardno2);
                    card2_OneClick = true;
                    return;
                }

                //For Deselect
                if (card2_OneClick == true)
                {
                    //For Icon
                    groupname = cards[cardno2].group;
                    if (listGroupNames.Contains(groupname))
                    {
                        listGroupNames.Remove(groupname);
                        if (!listGroupNames.Contains(groupname))
                        {
                            listIcons.Remove(groupname);
                            RemoveIcon();
                        }
                    }

                    //For Card
                    card2.transform.GetChild(0).gameObject.SetActive(false);
                    card2.color = new Color32(255, 255, 255, 255);
                    cardsSelected--;
                    DeSelectCard(cardno2);
                    card2_OneClick = false;
                    return;
                }
            }
            if (val == 3)
            {
                //For Select
                if (card3_OneClick == false)
                {
                    //For Icon
                    groupname = cards[cardno3].group;
                    listGroupNames.Add(groupname);
                    if (!listIcons.Contains(groupname))
                    {
                        listIcons.Add(groupname);
                        ShowIcon();
                    }

                    //For Card
                    card3.transform.GetChild(0).gameObject.SetActive(true);
                    card3.color = new Color32(255, 255, 255, 100);
                    cardsSelected++;
                    SelectCard(cardno3);
                    card3_OneClick = true;
                    return;
                }

                //For Deselect
                if (card3_OneClick == true)
                {
                    //For Icon
                    groupname = cards[cardno3].group;
                    if (listGroupNames.Contains(groupname))
                    {
                        listGroupNames.Remove(groupname);
                        if (!listGroupNames.Contains(groupname))
                        {
                            listIcons.Remove(groupname);
                            RemoveIcon();
                        }
                    }

                    //For Card
                    card3.transform.GetChild(0).gameObject.SetActive(false);
                    card3.color = new Color32(255, 255, 255, 255);
                    cardsSelected--;
                    DeSelectCard(cardno3);
                    card3_OneClick = false;
                    return;
                }
            }
            if (val == 4)
            {
                //For Select
                if (card4_OneClick == false)
                {
                    //For Icon
                    groupname = cards[cardno4].group;
                    listGroupNames.Add(groupname);
                    if (!listIcons.Contains(groupname))
                    {
                        listIcons.Add(groupname);
                        ShowIcon();
                    }

                    //For Card
                    card4.transform.GetChild(0).gameObject.SetActive(true);
                    card4.color = new Color32(255, 255, 255, 100);
                    cardsSelected++;
                    SelectCard(cardno4);
                    card4_OneClick = true;
                    return;
                }

                //For Deselect
                if (card4_OneClick == true)
                {
                    //For Icon
                    groupname = cards[cardno4].group;
                    if (listGroupNames.Contains(groupname))
                    {
                        listGroupNames.Remove(groupname);
                        if (!listGroupNames.Contains(groupname))
                        {
                            listIcons.Remove(groupname);
                            RemoveIcon();
                        }
                    }

                    //For Card
                    card4.transform.GetChild(0).gameObject.SetActive(false);
                    card4.color = new Color32(255, 255, 255, 255);
                    cardsSelected--;
                    DeSelectCard(cardno4);
                    card4_OneClick = false;
                    return;
                }
            }
            if (val == 5)
            {
                //For Select
                if (card5_OneClick == false)
                {
                    //For Icon
                    groupname = cards[cardno5].group;
                    listGroupNames.Add(groupname);
                    if (!listIcons.Contains(groupname))
                    {
                        listIcons.Add(groupname);
                        ShowIcon();
                    }

                    //For Card
                    card5.transform.GetChild(0).gameObject.SetActive(true);
                    card5.color = new Color32(255, 255, 255, 100);
                    cardsSelected++;
                    SelectCard(cardno5);
                    card5_OneClick = true;
                    return;
                }

                //For Deselect
                if (card5_OneClick == true)
                {
                    //For Icon
                    groupname = cards[cardno5].group;
                    if (listGroupNames.Contains(groupname))
                    {
                        listGroupNames.Remove(groupname);
                        if (!listGroupNames.Contains(groupname))
                        {
                            listIcons.Remove(groupname);
                            RemoveIcon();
                        }
                    }

                    //For Card
                    card5.transform.GetChild(0).gameObject.SetActive(false);
                    card5.color = new Color32(255, 255, 255, 255);
                    cardsSelected--;
                    DeSelectCard(cardno5);
                    card5_OneClick = false;
                    return;
                }
            }
        }
    }

    //Reserve a card for InGame
    void SelectCard(int val)
    {
        if (GameConstant.selectedCard1 == null)
        {
            GameConstant.selectedCard1 = "" + cards[val].cardName;
        }
        else if (GameConstant.selectedCard2 == null)
        {
            GameConstant.selectedCard2 = "" + cards[val].cardName;
        }
        else if (GameConstant.selectedCard3 == null)
        {
            GameConstant.selectedCard3 = "" + cards[val].cardName;
        }
        else if (GameConstant.selectedCard4 == null)
        {
            GameConstant.selectedCard4 = "" + cards[val].cardName;
        }
        else if (GameConstant.selectedCard5 == null)
        {
            GameConstant.selectedCard5 = "" + cards[val].cardName;
        }
        SoundPlayer._instance.PlaySound("CardSelect");
    }

    //Deselect a card for InGame
    void DeSelectCard(int val)
    {
        if (GameConstant.selectedCard1 != null)
        {
            GameConstant.selectedCard1 = null;
        }
        else if (GameConstant.selectedCard2 != null)
        {
            GameConstant.selectedCard2 = null;
        }
        else if (GameConstant.selectedCard3 != null)
        {
            GameConstant.selectedCard3 = null;
        }
        else if (GameConstant.selectedCard4 != null)
        {
            GameConstant.selectedCard4 = null;
        }
        else if (GameConstant.selectedCard5 != null)
        {
            GameConstant.selectedCard5 = null;
        }
        SoundPlayer._instance.PlaySound("cardRemove");
    }


    //Calculate & Show Icon Group
    void ShowIcon()
    {
        if (Icon1.gameObject.activeInHierarchy == false)
        {
            Icon1.gameObject.SetActive(true);
            if (groupname == "Animal")
                Icon1.sprite = AnimalIcon;
            if (groupname == "Robot")
                Icon1.sprite = RobotIcon;
            if (groupname == "Plant")
                Icon1.sprite = PlantIcon;
            if (groupname == "Dino")
                Icon1.sprite = DinoIcon;
        }
        else if (Icon2.gameObject.activeInHierarchy == false)
        {
            Icon2.gameObject.SetActive(true);
            if (groupname == "Animal")
                Icon2.sprite = AnimalIcon;
            if (groupname == "Robot")
                Icon2.sprite = RobotIcon;
            if (groupname == "Plant")
                Icon2.sprite = PlantIcon;
            if (groupname == "Dino")
                Icon2.sprite = DinoIcon;
        }
        else if (Icon3.gameObject.activeInHierarchy == false)
        {
            Icon3.gameObject.SetActive(true);
            if (groupname == "Animal")
                Icon3.sprite = AnimalIcon;
            if (groupname == "Robot")
                Icon3.sprite = RobotIcon;
            if (groupname == "Plant")
                Icon3.sprite = PlantIcon;
            if (groupname == "Dino")
                Icon3.sprite = DinoIcon;
        }
        else if (Icon4.gameObject.activeInHierarchy == false)
        {
            Icon4.gameObject.SetActive(true);
            if (groupname == "Animal")
                Icon4.sprite = AnimalIcon;
            if (groupname == "Robot")
                Icon4.sprite = RobotIcon;
            if (groupname == "Plant")
                Icon4.sprite = PlantIcon;
            if (groupname == "Dino")
                Icon4.sprite = DinoIcon;
        }
    }


    void RemoveIcon()
    {
        if (Icon1.gameObject.activeInHierarchy == true)
        {
            if (Icon1.sprite.name == groupname)
                Icon1.gameObject.SetActive(false);
        }
        if (Icon2.gameObject.activeInHierarchy == true)
        {
            if (Icon2.sprite.name == groupname)
                Icon2.gameObject.SetActive(false);
        }
        if (Icon3.gameObject.activeInHierarchy == true)
        {
            if (Icon3.sprite.name == groupname)
                Icon3.gameObject.SetActive(false);
        }
        if (Icon4.gameObject.activeInHierarchy == true)
        {
            if (Icon4.sprite.name == groupname)
                Icon4.gameObject.SetActive(false);
        }
    }


    //For Card Randomness
    private void ArrangeCards()
    {
        cardno1 = Random.Range(0, 15);
        cardno2 = Random.Range(0, 15);
        cardno3 = Random.Range(0, 15);
        cardno4 = Random.Range(0, 15);
        cardno5 = Random.Range(0, 15);
    }

    //For Card without Randomness
    private void ShuffleCards()
    {
        cardno1 = Random.Range(0, 15);
        list.Add(cardno1);

        cardno2 = Random.Range(0, 15);
        while (list.Count != 2)
        {
            if (list.Contains(cardno2))
            {
                cardno2 = Random.Range(0, 15);
            }
            else
            {
                list.Add(cardno2);
            }
        }

        cardno3 = Random.Range(0, 15);
        while (list.Count != 3)
        {
            if (list.Contains(cardno3))
            {
                cardno3 = Random.Range(0, 15);
            }
            else
            {
                list.Add(cardno3);
            }
        }

        cardno4 = Random.Range(0, 15);
        while (list.Count != 4)
        {
            if (list.Contains(cardno4))
            {
                cardno4 = Random.Range(0, 15);
            }
            else
            {
                list.Add(cardno4);
            }
        }

        cardno5 = Random.Range(0, 15);
        while (list.Count != 5)
        {
            if (list.Contains(cardno5))
            {
                cardno5 = Random.Range(0, 15);
            }
            else
            {
                list.Add(cardno5);
            }
        }
    }

    //To show card images on UI
    private void AssignCards()
    {
        card1.sprite = cards[cardno1].artwork;
        card2.sprite = cards[cardno2].artwork;
        card3.sprite = cards[cardno3].artwork;
        card4.sprite = cards[cardno4].artwork;
        card5.sprite = cards[cardno5].artwork;
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
