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
    int i = 0;
    int Count;
    GameObject[] MenuList = new GameObject[10] ;
    Text[] Menu = new Text[10];
    public GameObject MenuText;

    private void Awake()
    {
        send = GameObject.Find("Send");   
    }
    // Start is called before the first frame update
    void Start()
    {
        ss = send.GetComponent<SendScript>();

        frame = GameObject.Find("frame");

        Count = MenuText.transform.childCount;
        while(Count > i)
        {
            MenuList[i] = MenuText.transform.GetChild(i).gameObject;
            Menu[i] = MenuList[i].GetComponent<Text>();
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickAct()
    {
        if (MenuText.active)
        {
            i = 0;
            while(Count > i)
            {
                if (Menu[i].color == ss.UnselectedTextColor){
                }
                else if(Menu[i].color == ss.SelectedTextColor) {
                    Menu[i].color = ss.UnselectedTextColor;
                    if (i < Count -1)
                    {
                        Menu[i + 1].color = ss.SelectedTextColor;
                    }
                    else
                    {
                        Menu[0].color = ss.SelectedTextColor;
                    }
                    break;
                }
                i++;
            }
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
