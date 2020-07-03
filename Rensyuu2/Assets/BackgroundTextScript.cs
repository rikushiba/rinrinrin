using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BackgroundTextScript : MonoBehaviour
{
    TileBase UmiTile;
    TileBase UmiTile2;
    TileBase Nohara;
    TileBase Nohara2;
    TileBase DarkNohara;
    TileBase DarkNohara2;
    TileBase Beach;
    TileBase Beach2;


    GameObject send;
    SendScript sendscript;
    Text BackgroundText;
    GameObject frame;
    Vector3 framePosition;
    Vector3Int framePositionInt;
    Tilemap tilemap;
    GameObject background;
    TileBase tile;

    // Start is called before the first frame update
    void Awake()
    {
        send = GameObject.Find("Send");
        background = GameObject.Find("UmiBackground");
        BackgroundText = this.GetComponent<Text>();
    }
    void Start()
    {
        sendscript = send.GetComponent<SendScript>();
        UmiTile = sendscript.UmiTile;
        UmiTile2 = sendscript.UmiTile2;
        Nohara = sendscript.Nohara;
        Nohara2 = sendscript.Nohara2;
        Beach = sendscript.Beach;
        Beach2 = sendscript.Beach2;

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
        tile = (TileBase)tilemap.GetTile(framePositionInt);
        if (UmiTile == tile || UmiTile2 == tile)
        {
            BackgroundText.text = "海";
        }
        else if (Nohara == tile || Nohara2 == tile)
        {
            BackgroundText.text = "草原";
        }
        else if (DarkNohara == tile || DarkNohara2 == tile)
        {
            BackgroundText.text = "湿地";
        }
        else if (Beach == tile || Beach2 == tile)
        {
            BackgroundText.text = "砂浜";
        }
        else 
        {
            BackgroundText.text = "";
        }
    }
}
