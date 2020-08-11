using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class DownbuttonScript : MonoBehaviour
{
    GameObject send;
    SendScript ss;

    Text[] Menu = new Text[10];
    Text[] Map = new Text[10];
    private void Awake()
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
            if (ss.Frame2.transform.position.y >-9)
            {
                ss.Frame2.transform.Translate(0, -2, 0);
            }

        }
        else if(ss.MenuText.activeSelf)
        {
            ss.DownList(Menu, ss.MenuText);
        }
        else if (ss.MapMenu.activeSelf)
        {
            ss.DownList(Map, ss.MapMenu);
        }
        else
        {
            if (ss.Frame.transform.position.y > -9)
            {
                ss.Frame.transform.Translate(0, -1, 0);
            }
        }
    }
}
