using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattlePosition : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SideBoard"))
        {
            collision.GetComponent<DragableUI>().enabled = false;
            collision.gameObject.transform.position = this.transform.position;
            collision.gameObject.transform.rotation = this.transform.rotation;
            //Add sound
            SoundPlayer._instance.PlaySound("cardPlacement");
            //Add animation
            this.transform.parent.transform.GetChild(1).gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
