using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class UmiUpbuttonScript : MonoBehaviour
{
    GameObject send;
    SendScript ss;
    GameObject frame;

    Text[] Menu = new Text[10];
    Text[] Map = new Text[10];
    public GameObject MenuText;
    public GameObject MapMenu;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickAct()
    {
        if (MenuText.active)
        {
            ss.UpList(Menu, MenuText);
        }
        else if (MapMenu.activeSelf)
        {
            ss.UpList(Map, MapMenu);
        }
        else
        {
            if (frame.transform.position.y < 10)
            {
                frame.transform.Translate(0, 1, 0);
            }
            else
            {
                frame.transform.Translate(0, 0, 0);
            }
        }
    }
}
