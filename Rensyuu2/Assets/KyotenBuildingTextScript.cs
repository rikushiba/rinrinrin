using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class KyotenBuildingTextScript : MonoBehaviour
{
    GameObject send;
    SendScript ss;
    Text BuildingText;
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
        BuildingText = this.GetComponent<Text>();
        tilemap = ss.Building.GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        tile = (TileBase)tilemap.GetTile(ss.FposInt);
        if (tile == ss.Tree || tile == ss.Tree2 || tile == ss.Tree3 ||
                   tile == ss.Tree4 || tile == ss.Tree5 || tile == ss.Tree6 ||
                   tile == ss.Tree7 || tile == ss.Tree8)
        {
            BuildingText.text = "木";
        }
        else if (tile == ss.Rock || tile == ss.Rock2 || tile == ss.Rock3 ||
            tile == ss.Rock4 || tile == ss.Rock5 || tile == ss.Rock6)
        {
            BuildingText.text = "岩";
        }
        else
        {
            BuildingText.text = "---";
        }
    }
}
