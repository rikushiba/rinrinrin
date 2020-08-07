using System;
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
    Vector3 F2pos2;
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
    }
    public void onClickAct()
    {
        if (KT && Close && Frame2.activeSelf)
        {               
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
