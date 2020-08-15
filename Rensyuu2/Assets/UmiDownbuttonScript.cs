using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class UmiDownbuttonScript : MonoBehaviour
{
    GameObject send;
    SendScript ss;
    GameObject frame;

    public GameObject MenuText;
    public GameObject MapMenu;
    Text[] Boueki = new Text[10];
    Text[] Menu = new Text[10];
    Text[] Map = new Text[10];
    Text[] Yunyu = new Text[10];
    Text[] Yusyutsu = new Text[10];
    private void Awake()
    {
        send = GameObject.Find("Send");
    }
    // Start is called before the first frame update
    void Start()
    {
        ss = send.GetComponent<SendScript>();

        frame = GameObject.Find("frame");

        Menu = ss.GetList(MenuText);
        Map = ss.GetList(MapMenu);
        Boueki = ss.GetList(ss.BouekiMenu);
        Yunyu = ss.GetList(ss.YunyuMenu);
        Yusyutsu = ss.GetList(ss.YusyutsuMenu);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onClickAct()
    {
        if (ss.Yes.activeSelf)
        {

        }
        else if(ss.Frame2.activeSelf)
        {
            if (ss.Frame2.transform.position.y > -8)
            {
                ss.Frame2.transform.Translate(0, -2, 0);
            }
        }
        else if (MenuText.activeSelf)
        {
            ss.DownList(Menu, MenuText);
        }
        else if (MapMenu.activeSelf)
        {
            ss.DownList(Map, MapMenu);
        }
        else if (ss.BouekiMenu.activeSelf)
        {
            ss.DownList(Boueki, ss.BouekiMenu);
        }
        else if (ss.YunyuMenu.activeSelf)
        {
            ss.DownList(Yunyu, ss.YunyuMenu);
        }
        else if (ss.YusyutsuMenu.activeSelf)
        {
            ss.DownList(Yusyutsu, ss.YusyutsuMenu);
        }
        else
        {
            if (frame.transform.position.y > -8)
            {
                frame.transform.Translate(0, -1, 0);
            }
            else
            {
                frame.transform.Translate(0, 0, 0);
            }
        }
    }
}
