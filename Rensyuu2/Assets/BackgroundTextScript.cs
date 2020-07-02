using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BackgroundTextScript : MonoBehaviour
{
    public TileBase UmiTile;

    Text BackgroundText;
    GameObject frame;
    Vector3 framePosition;
    Vector3Int framePositionInt;
    Tilemap tilemap;
    GameObject background;

    // Start is called before the first frame update
    void Awake()
    {
        background = GameObject.Find("UmiBackground");
    }
    void Start()
    {
        BackgroundText = this.GetComponent<Text>();
        frame = GameObject.Find("frame");
        tilemap = background.GetComponent<Tilemap>();
        framePosition.z = 0;
        framePositionInt.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        framePosition = frame.transform.position;
        framePositionInt.x = (int)Mathf.Floor(framePosition.x);
        framePositionInt.y = (int)Mathf.Floor(framePosition.y);
        if (tilemap.GetTile(framePositionInt) == UmiTile)
        {
            Debug.Log("umi");
        }
    }
}
