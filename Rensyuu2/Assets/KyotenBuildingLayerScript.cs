using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class KyotenBuildingLayerScript : MonoBehaviour
{
    public TileBase Kyotentile;
    void Fill()
    {
        var tilemap = GetComponent<Tilemap>();
        var position = new Vector3Int(0, 0, 0);
        tilemap.BoxFill(position, Kyotentile, -10, -10, 10, 10);
    }

    // Start is called before the first frame update
    void Start()
    {
        void PositionGet()
        {
            int i = 0;
            var tilemap = GetComponent<Tilemap>();
            Vector3Int[] position = new Vector3Int[400];
            var bound = tilemap.cellBounds;
            for (int y = bound.max.y - 1; y >= bound.min.y; --y)
            {
                for (int x = bound.min.x; x < bound.max.x; ++x)
                {
                    position[i] = new Vector3Int(x, y, 0);
                    i++;
                }
            }

        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
