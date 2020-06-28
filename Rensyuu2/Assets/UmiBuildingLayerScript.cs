using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class UmiBuildingLayerScript : MonoBehaviour
{
    Vector3Int[] position = new Vector3Int[400];
    public TileBase umitile;
    Tilemap tilemap;

    // Start is called before the first frame update
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        int i = 0;
        var bound = tilemap.cellBounds;
        for (int y = 10; y >= -10; --y)
        {
            for (int x = -14; x < 6; ++x)
            {
                position[i] = new Vector3Int(x, y, 0);
                i++;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        var sposition = new Vector3Int(0, 0, 0);
        tilemap.BoxFill(sposition, umitile, -5, -5, 5, 5);
    }
}
