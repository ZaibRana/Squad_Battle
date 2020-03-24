using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardMatching : MonoBehaviour
{
    public Image[] Sideboards;
    int check1 = 0;
    //int check2 = 0;
    int cardRemove = 0;


    private void Start()
    {
        Matching();
    }


    private void Matching()
    {
        print("card matching starts..");

        for (int i = 0; i < GameConstant.battleCardsList.Count; i++)
        {
            if (GameConstant.battleCardsList[0].cardName == GameConstant.battleCardsList[i + 1].cardName)
            {
                print("Card 0 matched with..." + GameConstant.battleCardsList[i].cardName);
                check1++;
                if (check1 == 2)
                {
                    print("Check1 value 2...");
                    for (int j = 0; j < Sideboards.Length; j++)
                    {
                        print("h..");
                        if (GameConstant.battleCardsList[0].artwork == Sideboards[j].sprite)
                        {
                            Sideboards[j].gameObject.transform.GetChild(1).gameObject.SetActive(true);
                        }
                    }
                }
            }
        }
    }

    public void StartupBtn()
    {
        for (int j = 0; j < Sideboards.Length; j++)
        {
            if (GameConstant.battleCardsList[0].artwork == Sideboards[j].sprite && (GameConstant.battleCardsList[0].Tier == 1))
            {
                Sideboards[j].gameObject.transform.GetChild(1).gameObject.SetActive(false);//Startup button off

                if (cardRemove == 2)
                {
                    cardRemove = 0;

                    //Sound & Animation
                    SoundPlayer._instance.PlaySound("upgrade");
                    Sideboards[j].transform.GetChild(2).gameObject.SetActive(true);

                    //Acitve a star
                    Sideboards[j].transform.GetChild(3).gameObject.SetActive(true);

                    //Make it tier-2
                    return;
                }
                Sideboards[j].sprite = null;
                Sideboards[j].gameObject.SetActive(false);
                cardRemove++;
            }
        }
    }

    //To do
    //keep track of already existed cards...SOLVE
    //match new cards with already existed cards library...SOLVE
    //if match of 3 occurs, run an animation,sound and disapper 3 and make 1...SOLVE
    //Change value of that 1 tier 2 card with 15% extra all...SOLVE
    //Add start to that card...SOLVE


    //LATER
    //Have to make new sideboards while placement done to battle board
    //Have to add new sideboards here in this script to make it work.
}
