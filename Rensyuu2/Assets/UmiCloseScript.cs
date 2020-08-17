using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class UmiCloseScript : MonoBehaviour
{
    GameObject send;
    SendScript ss;
    Text MText;

    void Awake()
    {
        send = GameObject.Find("Send");
    }
    // Start is called before the first frame update
    void Start()
    {
        ss = send.GetComponent<SendScript>();
        MText = ss.MessageText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onClickAct()
    {
        if (ss.MenuText.activeSelf || ss.MapMenu.activeSelf || ss.Yes.activeSelf || ss.No.activeSelf || 
            (ss.Tenkuu && ss.Close && ss.Frame2) || ss.BouekiMenu.activeSelf || ss.YunyuMenu.activeSelf
            || ss.YusyutsuMenu.activeSelf)
        {
            ss.MapMenu.SetActive(false);
            ss.MenuText.SetActive(false);
            ss.Close.SetActive(false);
            ss.No.SetActive(false);
            ss.Yes.SetActive(false);
            ss.Tenkuu.SetActive(false);
            ss.Close.SetActive(false);
            ss.Frame2.SetActive(false);
            ss.Back.SetActive(false);
            ss.BouekiMenu.SetActive(false);
            ss.YunyuMenu.SetActive(false);
            ss.YusyutsuMenu.SetActive(false);
            ss.Key = 0;
            MText.text = "";
        }
        else
        {

        }
    }
    }
