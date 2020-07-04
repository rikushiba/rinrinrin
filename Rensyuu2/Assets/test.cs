using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class test : MonoBehaviour
{
    public TileBase tile;
    GameObject KyotenTenkuu;
    Tilemap tilemap;
    void Awake()
    {
        KyotenTenkuu = GameObject.Find("KyotenTenkuu");
    }

    // Start is called before the first frame update
    void Start()
    {
        
        tilemap = KyotenTenkuu.GetComponent<Tilemap>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var position = new Vector3Int(0, 0, 0);
        tilemap.SetTile(position, tile);
    }
    
}
