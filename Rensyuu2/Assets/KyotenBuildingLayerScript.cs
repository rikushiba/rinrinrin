using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class KyotenBuildingLayerScript : MonoBehaviour
{
    void PositionGet()
    {
        int i = 0;
        var tilemap = GetComponent<Tilemap>();
        Vector3Int[] position = new Vector3Int[400];
        var bound = tilemap.cellBounds;
        for (int y = bound.max.y-1;y>=bound.min.y; --y)
        {
            for (int x = bound.min.x; x<bound.max.x; ++x)
            {
                position[i] = new Vector3Int(x, y, 0);
                i++;
            }
        }
         
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
