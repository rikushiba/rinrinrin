using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BuildingTextScript : MonoBehaviour
{
    TileBase tree;
    TileBase tree2;
    TileBase tree3;
    TileBase tree4;
    TileBase tree5;
    TileBase tree6;
    TileBase tree7;
    TileBase tree8;

    GameObject send;
    SendScript sendscript;
    Text BuildingText;
    GameObject frame;
    Vector3 framePosition;
    Vector3Int framePositionInt;
    Tilemap tilemap;
    GameObject building;
    TileBase tile;
    // Start is called before the first frame update

    void Awake()
    {
        send = GameObject.Find("Send");
        building = GameObject.Find("UmiBuilding");
        BuildingText = this.GetComponent<Text>();
    }
    void Start()
    {
        sendscript = send.GetComponent<SendScript>();
        tree = sendscript.Tree;
        tree2 = sendscript.Tree2;
        tree3 = sendscript.Tree3;
        tree4 = sendscript.Tree4;
        tree5 = sendscript.Tree5;
        tree6 = sendscript.Tree6;
        tree7 = sendscript.Tree7;
        tree8 = sendscript.Tree8;

        frame = GameObject.Find("frame");
        tilemap = building.GetComponent<Tilemap>();
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

        if (tile == tree || tile == tree2 || tile == tree3 || 
            tile == tree4 || tile == tree5 || tile == tree6 || 
            tile == tree7 || tile == tree8 )
        {
            BuildingText.text = "木";
        }
        else 
        {
            BuildingText.text = "";
        }
    }
}
