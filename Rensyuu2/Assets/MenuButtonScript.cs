using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonScript : MonoBehaviour
{
    public GameObject MenuText;
    public GameObject MapMenu;
    GameObject send;
    SendScript ss;
    Text MText;

    // Start is called before the first frame update
    void Awake()
    {
        send = GameObject.Find("Send");
    }
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
        if (MenuText.activeSelf || MapMenu.activeSelf || ss.BouekiMenu.activeSelf || ss.YusyutsuMenu.activeSelf
            || ss.YunyuMenu.activeSelf)
        {
            MapMenu.SetActive(false);
            MenuText.SetActive(false);
            ss.BouekiMenu.SetActive(false);
            ss.YusyutsuMenu.SetActive(false);
            ss.YunyuMenu.SetActive(false);
            ss.Close.SetActive(false);
            ss.Key = 0;
        }
        else
        {
            MenuText.SetActive(true);
            ss.Close.SetActive(true);
            ss.No.SetActive(false);
            ss.Yes.SetActive(false);
            MText.text = "";
        }
    }
}
