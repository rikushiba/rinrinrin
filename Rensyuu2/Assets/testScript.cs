using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Tilemaps;

public class testScript : MonoBehaviour
{
    Tilemap map;
    private void Awake()
    {
        map = GetComponent<Tilemap>();
        var position = new Vector3Int(0, 0, 0);
        Tile t = (Tile)map.GetTile(position);

        var position2 = new Vector3Int(1, 1, 0);
        map.SetTile(position2, t);
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
