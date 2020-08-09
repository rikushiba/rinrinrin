using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class UmiSelectScript : MonoBehaviour
{
    public GameObject MenuText;
    public GameObject MapMenu;
    public GameObject Map;
    public GameObject Yama;
    public GameObject Kyoten;
    public Tilemap UBamap;
    public Tilemap UBumap;
    public Tilemap UTmap;

    Text MapText;
    Text YamaText;
    Text KyotenText;
    Text MText;
    Text YText;
    Text NText;

    GameObject send;
    SendScript ss;   

    Vector3 F2pos;
    Vector3 F2pos2;
    Vector3 F2pos3;
    Vector3Int UTpos;

    TileBase t;
    TileBase t2;
    TileBase pret1;
    TileBase pret2;

    void Awake()
    {
        send = GameObject.Find("Send");
    }
    // Start is called before the first frame update
    void Start()
    {
        ss = send.GetComponent<SendScript>();
        MapText = Map.GetComponent<Text>();
        YamaText = Yama.GetComponent<Text>();
        KyotenText = Kyoten.GetComponent<Text>();
        MText = ss.MessageText.GetComponent<Text>();
        YText = ss.Yes.GetComponent<Text>();
        NText = ss.No.GetComponent<Text>();
       
    }

    // Update is called once per frame
    void Update()
    {       
        F2pos = ss.Frame2.transform.position;
        F2pos2 = new Vector3();
        F2pos2.x = F2pos.x;
        F2pos2.y = F2pos.y - 1;
        F2pos2.z = F2pos.z;
        //F2posのy座標を-1する

        F2pos3 = F2pos2 * 0.5f;
        //F2pos2の座標を半分にする

        UTpos = new Vector3Int();
        UTpos.x = Mathf.FloorToInt(F2pos3.x);
        UTpos.y = Mathf.FloorToInt(F2pos3.y);
        UTpos.z = (int)F2pos2.z;
        //F2pos3の座標を切り捨て

        t = UBumap.GetTile(ss.FposInt);
        t2 = UTmap.GetTile(UTpos);
        pret1 = UBumap.GetTile(ss.FposInt);
        pret2 = UBamap.GetTile(ss.FposInt);
    }

    public void onClickAct()
    {
        if (MenuText.activeSelf)
        {
            if (MapText.color == ss.SelectedTextColor)
            {
                MenuText.SetActive(false);
                MapMenu.SetActive(true);
            }
        }
        else if (MapMenu.activeSelf)
        {
            if (YamaText.color == ss.SelectedTextColor)
            {
                SceneManager.LoadScene("Ymascene");
            }
            else if (KyotenText.color == ss.SelectedTextColor)
            {
                SceneManager.LoadSceneAsync("KyotenScene");
            }
        }
        else if (ss.Tenkuu && ss.Frame2 && ss.Close.activeSelf)
        {
            if (UBumap.HasTile(ss.FposInt))
            {

            }
            else if (pret2 == ss.UmiTile || pret2 == ss.UmiTile2 || pret2 == ss.Beach || pret2 == ss.Beach2)
            {

            }
            else
            {
                UBumap.SetTile(ss.FposInt,t2);
            }
        }
        else if (ss.Key == 1)
        {
            if (YText.color == ss.SelectedTextColor)
            {
                UBumap.SetTile(ss.FposInt, null);
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
