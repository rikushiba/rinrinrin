﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpbuttonScript : MonoBehaviour
{
   public GameObject frame;
   public GameObject frame2;

    Text[] Menu = new Text[10];
    Text[] Map = new Text[10];
    GameObject send;
    SendScript ss;
    void Awake()
    {
        send = GameObject.Find("Send");
    }
    // Start is called before the first frame update
    void Start()
    {
        ss = send.GetComponent<SendScript>();
        Menu = ss.GetList(ss.MenuText);
        Map = ss.GetList(ss.MapMenu);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickAct()
    {
        if (ss.Frame2.activeSelf)
        {
            if (ss.Frame2.transform.position.y < -7)
            {
                ss.Frame2.transform.Translate(0, 2, 0);
            }
        }
        else if (ss.MenuText.activeSelf)
        {
            ss.UpList(Menu, ss.MenuText);
        }
        else if (ss.MapMenu.activeSelf)
        {
            ss.UpList(Map, ss.MapMenu);
        }
        else
        {
            if (ss.Frame.transform.position.y < 9)
            {
                ss.Frame.transform.Translate(0, 1, 0);
            }
        
        }
    }
}
