using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenScript : MonoBehaviour
{
    public Tilemap KBamap;
    public Tilemap KBumap;
    public Tilemap KTmap;
    public GameObject Map;
    public GameObject Yama;
    public GameObject Umi;

    GameObject send;
    SendScript ss;
    GameObject Close;
    GameObject Frame;
    GameObject Frame2;
    GameObject KT;

    Vector3 Fpos;
    Vector3 F2pos;
    Vector3 F2pos2;
    Vector3Int KBpos;
    Vector3Int KTpos;

    TileBase t;
    TileBase t2;
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
    TileBase UmiTile;
    TileBase UmiTile2;
    TileBase DN;
    TileBase DN2;
    TileBase Beach;
    TileBase Beach2;

    Text MapText;
    Text YamaText;
    Text UmiText;
    Text MText;
    Text YText;
    Text NText;

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
        KT = ss.Tenkuu;
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
        UmiTile = ss.UmiTile;
        UmiTile2 = ss.UmiTile2;
        DN = ss.DarkNohara;
        DN2 = ss.DarkNohara2;
        Beach = ss.Beach;
        Beach2 = ss.Beach2;

        MapText = Map.GetComponent<Text>();
        YamaText = Yama.GetComponent<Text>();
        UmiText = Umi.GetComponent<Text>();
        MText = ss.MessageText.GetComponent<Text>();
        YText = ss.Yes.GetComponent<Text>();
        NText = ss.No.GetComponent<Text>();
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

        t2 = KTmap.GetTile(KTpos);
        pret1 = KBumap.GetTile(KBpos);
        pret2 = KBamap.GetTile(KBpos);

        t = KBumap.GetTile(ss.FposInt);
    }
    public void onClickAct()
    {
        if (KT && Close && Frame2.activeSelf)
        {
           // if (pret1 == Tree || pret1 == Tree2 || 
            //pret1 == Tree3 || pret1 == Tree4 || pret1 == Tree5 || 
            //pret1 == Tree6 || pret1 == Tree7 || pret1 == Tree8 ||
            //pret1 == Rock || pret1 == Rock2 || pret1 == Rock3 ||
            //pret1 == Rock4 || pret1 == Rock5 || pret1 == Rock6)
            //一応タイルごとに書いたけど使わないかも           
            if ( KBumap.HasTile(KBpos) )
            {
                
            }
            else if ( pret2 == UmiTile || pret2 == UmiTile2 ||
                pret2 == DN || pret2 == DN2 || pret2 == Beach ||
                pret2 == Beach2 )
            {

            }
            else
            {
                KBumap.SetTile(KBpos, t2);
            }
        }
        else if (ss.MenuText.activeSelf)
        {
            if (MapText.color == ss.SelectedTextColor)
            {
                ss.MenuText.SetActive(false);
                ss.MapMenu.SetActive(true);
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
                KT.SetActive(true);
                Close.SetActive(true);
                Frame2.SetActive(true);
            }
        }
    }
}
