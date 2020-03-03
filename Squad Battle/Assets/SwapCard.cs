using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCard : MonoBehaviour
{
    [HideInInspector] public Vector3 InitialPos;
    bool check;
    Vector3 otherPos;

    private void OnEnable()
    {
        check = true;
        InitialPos = this.transform.position;
    }

    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BattleBoard") && check == true)
        {
            //otherPos = new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z);
            this.GetComponent<DragableUI>().enabled = false;
            Drag_Off();

            collision.gameObject.AddComponent<SwapLocation>();
            collision.gameObject.GetComponent<SwapLocation>().OtherPos = this.InitialPos;
            collision.gameObject.GetComponent<SwapLocation>().Otheroffset = this.GetComponent<BoxCollider2D>().offset;
            collision.gameObject.GetComponent<SwapLocation>().OtherSize = this.GetComponent<BoxCollider2D>().size;
            collision.gameObject.GetComponent<SwapLocation>().OtherEdgeRadius = this.GetComponent<BoxCollider2D>().edgeRadius;

            //Add sound
            SoundPlayer._instance.PlaySound("cardPlacement");
            //Add animation
            //this.transform.parent.transform.GetChild(1).gameObject.SetActive(true);
            check = false;
            print("Swap Card Fun..");
            this.transform.position = collision.transform.position;

            this.GetComponent<BoxCollider2D>().offset = collision.GetComponent<BoxCollider2D>().offset;
            this.GetComponent<BoxCollider2D>().size = collision.GetComponent<BoxCollider2D>().size;
            this.GetComponent<BoxCollider2D>().edgeRadius = collision.GetComponent<BoxCollider2D>().edgeRadius;

            Destroy(this.GetComponent<SwapCard>());
        }
    }

    private void Drag_Off()
    {
        Destroy(this.gameObject.GetComponent<SwapCard>());
        this.tag = "BattleBoard";
        print("Destroy Swap card");
    }

}
