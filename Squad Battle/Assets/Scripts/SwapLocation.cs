using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapLocation : MonoBehaviour
{

    public Vector3 OtherPos;
    public Vector2 Otheroffset;
    public Vector2 OtherSize;
    public float OtherEdgeRadius;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = OtherPos;
        this.GetComponent<DragableUI>().enabled = true;
        this.gameObject.AddComponent<SwapCard>();
        this.gameObject.tag = "SideBoard";

        this.GetComponent<BoxCollider2D>().offset = Otheroffset;
        this.GetComponent<BoxCollider2D>().size = OtherSize;
        this.GetComponent<BoxCollider2D>().edgeRadius = OtherEdgeRadius;

        Destroy(this.gameObject.GetComponent<SwapLocation>());
    }

}
