using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class KyotenBackgroundTextScript : MonoBehaviour
{
    GameObject send;
    SendScript ss;
    Text BackgroundText;
    Tilemap tilemap;
    TileBase tile;
    void Awake()
    {
        send = GameObject.Find("Send");
    }
    // Start is called before the first frame update
    void Start()
    {
        ss = send.GetComponent<SendScript>();
        BackgroundText = this.GetComponent<Text>();
        tilemap = ss.Background.GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        tile = (TileBase)tilemap.GetTile(ss.FposInt);
        if (ss.UmiTile == tile || ss.UmiTile2 == tile)
        {
            BackgroundText.text = "海";
        }
        else if (ss.Nohara == tile || ss.Nohara2 == tile)
        {
            BackgroundText.text = "草原";
        }
        else if (ss.DarkNohara == tile || ss.DarkNohara2 == tile)
        {
            BackgroundText.text = "湿地";
        }
        else if (ss.Beach == tile || ss.Beach2 == tile)
        {
            BackgroundText.text = "川辺";
        }
        else if (ss.Iwaba == tile || ss.Iwaba2 == tile)
        {
            BackgroundText.text = "岩場";
        }
        else if (ss.Tsuchi == tile || ss.Tsuchi2 == tile)
        {
            BackgroundText.text = "土";
        }
        else
        {
            BackgroundText.text = "---";
        }
    }
}
