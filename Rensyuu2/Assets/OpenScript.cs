using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
using System.Net.Sockets;

public class OpenScript : MonoBehaviour
{
    public Tilemap KBamap;
    public Tilemap KBumap;
    public Tilemap KTmap;
    public GameObject Shop;
    public GameObject Map;
    public GameObject Yama;
    public GameObject Umi;

    GameObject send;
    SendScript ss;

    Vector3 Fpos;
    Vector3 F2pos;
    Vector3 F2pos2;
    Vector3Int KTpos;
    Vector3Int firstp;
    Vector3Int lastp;

    BoundsInt bound;

    TileBase t;
    TileBase t2;
    TileBase pret1;
    TileBase pret2;
    TileBase[] tlist;

    Text ShopText;
    Text MapText;
    Text YamaText;
    Text UmiText;
    Text MText;
    Text YText;
    Text NText;

    int stcount;

    private void Awake()
    {        
        send = GameObject.Find("Send");
    }


    // Start is called before the first frame update
    void Start()
    {
        ss = send.GetComponent<SendScript>();

        ShopText = Shop.GetComponent<Text>();
        MapText = Map.GetComponent<Text>();
        YamaText = Yama.GetComponent<Text>();
        UmiText = Umi.GetComponent<Text>();
        MText = ss.MessageText.GetComponent<Text>();
        YText = ss.Yes.GetComponent<Text>();
        NText = ss.No.GetComponent<Text>();

        stcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        F2pos = ss.Frame2.transform.position;
        F2pos2 = F2pos * 0.5f; 
        //F2posの座標を半分にする

        KTpos = new Vector3Int();
        KTpos.x = Mathf.FloorToInt(F2pos2.x);
        KTpos.y = Mathf.FloorToInt(F2pos2.y);
        KTpos.z = (int)F2pos2.z;
        //F2pos2の座標を切り捨て

        firstp = new Vector3Int();
        firstp.x = ss.FposInt.x - 1;
        firstp.y = ss.FposInt.y - 1;
        firstp.z = ss.FposInt.z;

        lastp = new Vector3Int();
        lastp.x = ss.FposInt.x + 1;
        lastp.y = ss.FposInt.y + 1;
        lastp.z = ss.FposInt.z;

        t = KBumap.GetTile(ss.FposInt);
        t2 = KTmap.GetTile(KTpos);

        pret1 = KBumap.GetTile(ss.FposInt);
        pret2 = KBamap.GetTile(ss.FposInt);

        bound = new BoundsInt(ss.FposInt, new Vector3Int(1, 1, 0));

        tlist = KBumap.GetTilesBlock(bound);

        

        for (int i = 0; i < tlist.Length; i++)
        {
            if (tlist[i] == null)
            {
                stcount = +1;
            }
        }
    }
    public void onClickAct()
    {
        if (ss.Tenkuu.activeSelf && ss.Close.activeSelf && ss.Frame2.activeSelf && !(ss.Back.activeSelf) )
        {
           //if (pret1 == Tree || pret1 == Tree2 || 
            //pret1 == Tree3 || pret1 == Tree4 || pret1 == Tree5 || 
            //pret1 == Tree6 || pret1 == Tree7 || pret1 == Tree8 ||
            //pret1 == Rock || pret1 == Rock2 || pret1 == Rock3 ||
            //pret1 == Rock4 || pret1 == Rock5 || pret1 == Rock6)
            //一応タイルごとに書いたけど使わないかも           
            if ( KBumap.HasTile(ss.FposInt) )
            {
                
            }
            else if ( pret2 == ss.UmiTile || pret2 == ss.UmiTile2 ||
                pret2 == ss.DarkNohara || pret2 == ss.DarkNohara2 || 
                pret2 == ss.Beach || pret2 == ss.Beach2 )
            {

            }
            else
            {
                if (stcount <= 5)
                KBumap.SetTile(ss.FposInt, t2);
            }
        }
        else if (ss.Tenkuu.activeSelf  && ss.Frame2.activeSelf && ss.Back.activeSelf && ss.Close.activeSelf )
        {
            ss.Tenkuu.SetActive(false);
            ss.Frame2.SetActive(false);
            ss.Close.SetActive(false);
        }
        else if (ss.Back.activeSelf && !(ss.Frame2.activeSelf) && !(ss.MapMenu.activeSelf) )
        {
            if (KBumap.HasTile(ss.FposInt))
            {

            }
            else if (pret2 == ss.UmiTile || pret2 == ss.UmiTile2 ||
                pret2 == ss.DarkNohara || pret2 == ss.DarkNohara2 ||
                pret2 == ss.Beach || pret2 == ss.Beach2)
            {

            }
            else
            {
                if (stcount <= 5)
                {
                    KBumap.SetTile(ss.FposInt, t2);
                }
            }
        }
        else if (ss.MenuText.activeSelf)
        {
            if (ShopText.color == ss.SelectedTextColor)
            {
                ss.Tenkuu.SetActive(true);
                ss.Frame2.SetActive(true);
                ss.MenuText.SetActive(false);
                ss.Back.SetActive(true);
            }
            else if (MapText.color == ss.SelectedTextColor)
            {
                ss.MenuText.SetActive(false);
                ss.MapMenu.SetActive(true);
                ss.Back.SetActive(true);
            }
        }
        else if (ss.MapMenu.activeSelf)
        {
            if (YamaText.color == ss.SelectedTextColor)
            {
                SceneManager.LoadScene("Ymascene");
            }
            else if (UmiText.color == ss.SelectedTextColor)
            {
                SceneManager.LoadSceneAsync("UmiScene");
            }
        }
        else if (ss.Key == 1)
        {
            if (YText.color == ss.SelectedTextColor)
            {
                KBumap.SetTile(ss.FposInt, null);
                ss.No.SetActive(false);
                ss.Yes.SetActive(false);
                ss.Close.SetActive(false);
                ss.Key = 0;
                MText.text = "";
            }
            else if (NText.color == ss.SelectedTextColor)
            {
                ss.No.SetActive(false);
                ss.Yes.SetActive(false);
                ss.Close.SetActive(false);
                ss.Key = 0;
                MText.text = "";
                ss.YesOrNo();
            }
        }
        else
        {
            if (t == ss.Rock || t == ss.Rock2 || t == ss.Rock3 || t == ss.Rock4 || t == ss.Rock5 || t == ss.Rock6)
            {
                ss.Key = 1;/*if分岐に使う*/
                MText.text = ss.RemoveRockCost.ToString("d") + "円で岩を除去しますか？";
                ss.Yes.SetActive(true);
                ss.No.SetActive(true);
                ss.Close.SetActive(true);
            }
            else if (t == ss.Tree || t == ss.Tree2 || t == ss.Tree3 || t == ss.Tree4 || t == ss.Tree5 || t == ss.Tree6 || t == ss.Tree7 || t == ss.Tree8)
            {
                ss.Key = 1;/*if分岐に使う*/
                MText.text = ss.RemoveTreeCost.ToString("d") + "円で木を除去しますか？";
                ss.Yes.SetActive(true);
                ss.No.SetActive(true);
                ss.Close.SetActive(true);
            }
            else
            {
                ss.Tenkuu.SetActive(true);
                ss.Close.SetActive(true);
                ss.Frame2.SetActive(true);
            }
        }
    }
}
