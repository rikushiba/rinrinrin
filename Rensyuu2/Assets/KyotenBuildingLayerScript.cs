using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class KyotenBuildingLayerScript : MonoBehaviour
{
    public TileBase Kyotentile;
    Tilemap tilemap;
    void Fill()
    {
        
        // Start is called before the first frame update
        void Start()
        {
            tilemap = GetComponent<Tilemap>();
        }


        // Update is called once per frame
        void Update()
        {
            var uposition = new Vector3Int(0, 0, 0);
            tilemap.BoxFill(uposition, Kyotentile, -5, -5, 5, 5);
        }
    }
}