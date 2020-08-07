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
        else if (MapMenu.activeSelf){
            if(YamaText.color == ss.SelectedTextColor)
            {
                SceneManager.LoadScene("Ymascene");
            }
            else if(KyotenText.color == ss.SelectedTextColor)
            {
                SceneManager.LoadSceneAsync("KyotenScene");
            }
        }
        else
        {
            if (t == ss.Rock || t == ss.Rock2 || t == ss.Rock3 || t == ss.Rock4 || t == ss.Rock5 || t == ss.Rock6)
            {
                UnityEngine.Debug.Log("a");
            }
            else if( t == ss.Tree || ss.Tree2 || ss.Tree3 || ss.Tree4 || ss.Tree5 || ss.Tree6 || ss.Tree7 || ss.Tree8)
            {

            }
        }
    }
}
