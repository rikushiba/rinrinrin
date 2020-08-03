using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OpenScript : MonoBehaviour
{
    public Tilemap KBmap;  
    public Tilemap KTmap;
    public GameObject KT;
    public GameObject Close;
    public GameObject Frame2;

    private void Awake()
    {
        KBmap = GetComponent<Tilemap>();
        KTmap = GetComponent<Tilemap>();

        var KTpos = new Vector3Int(0, 0, 0);
        Tile t = (Tile)KTmap.GetTile(KTpos);

        var KBpos = new Vector3Int(1, 1, 0);
        KBmap.SetTile(KBpos, t);
    }


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickAct()
    {
        if (KT && Close && Frame2.active)
        {
            
        }
        else
        {
            KT.SetActive(true);
            Close.SetActive(true);
            Frame2.SetActive(true);
        }
    }
}
