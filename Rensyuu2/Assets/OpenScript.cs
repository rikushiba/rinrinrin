using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OpenScript : MonoBehaviour
{
    public Tilemap KBamap;
    public Tilemap KBumap;
    public Tilemap KTmap;
    public GameObject KT;
    
    GameObject send;
    SendScript ss;
    GameObject Close;
    GameObject Frame;
    GameObject Frame2;

    Vector3 Fpos;
    Vector3 F2pos;
    Vector3 F2pos2;
    Vector3Int KBpos;
    Vector3Int KTpos;

    TileBase t;
    TileBase pret1;
    TileBase pret2;
    TileBase Tree;
    TileBase Tree2;
    TileBase Tree3;
    TileBase Tree4;
    TileBase Tree5;
    TileBase Tree6;
    TileBase Tree7;
    TileBase Tree8;
    TileBase Rock;
    TileBase Rock2;
    TileBase Rock3;
    TileBase Rock4;
    TileBase Rock5;
    TileBase Rock6;

    private void Awake()
    {        
        send = GameObject.Find("Send");
    }


    // Start is called before the first frame update
    void Start()
    {
        ss = send.GetComponent<SendScript>();
        Close = ss.Close;
        Frame = ss.Frame;
        Frame2 = ss.Frame2;
        Tree = ss.Tree;
        Tree2 = ss.Tree2;
        Tree3 = ss.Tree3;
        Tree4 = ss.Tree4;
        Tree5 = ss.Tree5;
        Tree6 = ss.Tree6;
        Tree7 = ss.Tree7;
        Tree8 = ss.Tree8;
        Rock = ss.Rock;
        Rock2 = ss.Rock2;
        Rock3 = ss.Rock3;
        Rock4 = ss.Rock4;
        Rock5 = ss.Rock5;
        Rock6 = ss.Rock6;
    }

    // Update is called once per frame
    void Update()
    {
        F2pos = Frame2.transform.position;
        F2pos2 = F2pos * 0.5f; 
        //F2posの座標を半分にする

        KTpos = new Vector3Int();
        KTpos.x = Mathf.FloorToInt(F2pos2.x);
        KTpos.y = Mathf.FloorToInt(F2pos2.y);
        KTpos.z = (int)F2pos2.z;
        //F2pos2の座標を切り捨て

        Fpos = Frame.transform.position;
        KBpos = new Vector3Int();
        KBpos.x = Mathf.FloorToInt(Fpos.x);
        KBpos.y = Mathf.FloorToInt(Fpos.y);
        KBpos.z = (int)Fpos.z;

        t = KTmap.GetTile(KTpos);
        pret1 = KBumap.GetTile(KBpos);
        pret2 = KBamap.GetTile(KBpos);
    }
    public void onClickAct()
    {
        if (KT && Close && Frame2.activeSelf)
        {
            //if (pret1 == Tree || Tree2 || Tree3 || Tree4 || Tree5 || Tree6 || Tree7 || Tree8 || Rock || Rock2 || Rock3 || Rock4 || Rock5 || Rock6)
            

            
            //else
            
                KBumap.SetTile(KBpos, t);
            
        }
        else
        {
            KT.SetActive(true);
            Close.SetActive(true);
            Frame2.SetActive(true);
        }
    }
}
