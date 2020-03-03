using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFriend : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SideBoard"))
        {
            collision.GetComponent<DragableUI>().enabled = false;
            //Drag_Off();

            collision.gameObject.transform.position = this.transform.position;
            collision.gameObject.transform.rotation = this.transform.rotation;
            //Add sound
            SoundPlayer._instance.PlaySound("cardRemove");
            collision.gameObject.SetActive(false);
        }
    }

    //private void Drag_Off()
    //{
    //    Destroy(this.gameObject.GetComponent<SwapCard>());
    //    this.tag = "BattleBoard";
    //    print("Destroy Swap card");
    //}
}
