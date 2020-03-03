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
            Destroy(collision.gameObject.GetComponent<SwapCard>());
            collision.tag = "BattleBoard";

            collision.gameObject.transform.position = this.transform.position;
            collision.gameObject.transform.rotation = this.transform.rotation;
            //Add sound
            SoundPlayer._instance.PlaySound("cardPlacement");
            //Add animation
            this.transform.parent.transform.GetChild(1).gameObject.SetActive(true);
            Destroy(this.gameObject.GetComponent<BattlePosition>());

            collision.GetComponent<BoxCollider2D>().offset = this.GetComponent<BoxCollider2D>().offset;
            collision.GetComponent<BoxCollider2D>().size = this.GetComponent<BoxCollider2D>().size;
            collision.GetComponent<BoxCollider2D>().edgeRadius = this.GetComponent<BoxCollider2D>().edgeRadius;

            Destroy(this.gameObject.GetComponent<BoxCollider2D>());
            this.gameObject.SetActive(false);
        }
    }
}
