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
    Text MapText;
    Text YamaText;
    Text KyotenText;
    Text MText;
    Text YText;
    Text NText;
    GameObject send;
    SendScript ss;

    public Tilemap UB;
    TileBase t;

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
        t = UB.GetTile(ss.FposInt);
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
        else if (MapMenu.activeSelf) {
            if (YamaText.color == ss.SelectedTextColor)
            {
                SceneManager.LoadScene("Ymascene");
            }
            else if (KyotenText.color == ss.SelectedTextColor)
            {
                SceneManager.LoadSceneAsync("KyotenScene");
            }
        }
        else if (ss.Key == 1)
        {
            if(YText.color == ss.SelectedTextColor)
            {
                UB.SetTile(ss.FposInt, null);
                ss.No.SetActive(false);
                ss.Yes.SetActive(false);
                ss.Key = 0;
                MText.text = "";
            }
            else if(NText.color == ss.SelectedTextColor)
            {
                ss.No.SetActive(false);
                ss.Yes.SetActive(false);
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
                MText.text = ss.RemoveRockCost.ToString("d") +"円で岩を除去しますか？";
                ss.Yes.SetActive(true);
                ss.No.SetActive(true);
                ss.Close.SetActive(true);
            }
            else if( t == ss.Tree || t == ss.Tree2 || t == ss.Tree3 || t == ss.Tree4 || t == ss.Tree5 || t == ss.Tree6 || t == ss.Tree7 || t == ss.Tree8)
            {
                ss.Key = 1;/*if分岐に使う*/
                MText.text = ss.RemoveTreeCost.ToString("d") + "円で木を除去しますか？";
                ss.Yes.SetActive(true);
                ss.No.SetActive(true);
                ss.Close.SetActive(true);
            }
        }
    }
}
