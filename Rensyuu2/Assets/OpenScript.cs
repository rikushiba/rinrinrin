using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OpenScript : MonoBehaviour
{
    public Tilemap KBmap;
    public Tilemap KTmap;
    public GameObject KT;
    
    GameObject send;
    SendScript sendscript;
    GameObject Close;
    GameObject Frame;
    GameObject Frame2;

    Vector3 Fpos;
    Vector3 F2pos;
    Vector3Int KBpos;
    Vector3Int KTpos;

    TileBase t;

    private void Awake()
    {        
        send = GameObject.Find("Send");
    }


    // Start is called before the first frame update
    void Start()
    {
        sendscript = send.GetComponent<SendScript>();
        Close = sendscript.Close;
        Frame = sendscript.Frame;
        Frame2 = sendscript.Frame2;

    }

    // Update is called once per frame
    void Update()
    {
        Fpos = Frame.transform.position;
        KTpos = new Vector3Int();
        KTpos.x = (int)F2pos.x - 1;
        KTpos.y = (int)F2pos.y - 1;
        KTpos.z = (int)F2pos.z;

        F2pos = Frame2.transform.position;
        KBpos = new Vector3Int();
        KBpos.x = Mathf.FloorToInt(Fpos.x);
        KBpos.y = Mathf.FloorToInt(Fpos.y);
        KBpos.z = (int)Fpos.z;

        t = KTmap.GetTile(KTpos);
    }
    public void onClickAct()
    {
        if (KT && Close && Frame2.activeSelf)
        {
            //Vector3 F2pos = GameObject.Find("frame2").transform.position;
            //Vector3Int KTpos = new Vector3Int();
            //KTpos.x = (int)F2pos.x -1;
            //KTpos.y = (int)F2pos.y -1;
            //KTpos.z = (int)F2pos.z;    

            //Tile t = (Tile)KTmap.GetTile(KTpos);
            
            //Vector3 Fpos = GameObject.Find("frame").transform.position;
            //Vector3Int KBpos = new Vector3Int();
            //KBpos.x = Mathf.FloorToInt(Fpos.x) ;
            //KBpos.y = Mathf.FloorToInt(Fpos.y);
            //KBpos.z = (int)Fpos.z;

            //KBmap.SetTile(KBpos, t);
            
            KBmap.SetTile(KBpos, t);
        }
        else
        {
            KT.SetActive(true);
            Close.SetActive(true);
            Frame2.SetActive(true);
        }
    }
}
