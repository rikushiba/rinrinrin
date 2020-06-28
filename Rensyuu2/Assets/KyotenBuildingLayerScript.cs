using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class KyotenBuildingLayerScript : MonoBehaviour
{
    public TileBase Kyotentile;
    Tilemap tilemap;
    
    
        
        // Start is called before the first frame update
        void Start()
        {
            tilemap = GetComponent<Tilemap>();
        }


        // Update is called once per frame
        void Update()
        {
            var uposition = new Vector3Int(4,-8,0 );
            tilemap.SetTile(uposition, Kyotentile);
        }
    
}