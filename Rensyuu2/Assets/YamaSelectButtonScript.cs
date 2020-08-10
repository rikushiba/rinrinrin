using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YamaSelectButtonScript : MonoBehaviour
{
    public Tilemap KBamap;
    public Tilemap YBumap;
    public Tilemap KTmap;
    public GameObject Map;
    public GameObject Kyoten;
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
    Text KyotenText;
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

        MapText = Map.GetComponent<Text>();
        KyotenText = Kyoten.GetComponent<Text>();
        UmiText = Umi.GetComponent<Text>();
        MText = ss.MessageText.GetComponent<Text>();
        YText = ss.Yes.GetComponent<Text>();
        NText = ss.No.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        t = YBumap.GetTile(ss.FposInt);
    }

    public void onClickAct()
    {
        if (ss.MenuText.activeSelf)
        {
            if (MapText.color == ss.SelectedTextColor)
            {
                ss.MenuText.SetActive(false);
                ss.MapMenu.SetActive(true);
            }
        }
        else if (ss.MapMenu.activeSelf)
        {
            if (KyotenText.color == ss.SelectedTextColor)
            {
                SceneManager.LoadScene("Kyotenscene");
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
                YBumap.SetTile(ss.FposInt, null);
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
               /* KT.SetActive(true);
                Close.SetActive(true);
                Frame2.SetActive(true);*/
            }
        }
    }
}
