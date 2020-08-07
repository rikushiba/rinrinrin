using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class MenuButtonScript : MonoBehaviour
{
    public GameObject MenuText;
    public GameObject MapMenu;
    GameObject send;
    SendScript ss;

    // Start is called before the first frame update
    void Awake()
    {
        send = GameObject.Find("Send");
    }
    void Start()
    {
        ss = send.GetComponent<SendScript>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void onClickAct()
    {
        if (MenuText.activeSelf || MapMenu.activeSelf)
        {
            MapMenu.SetActive(false);
            MenuText.SetActive(false);
            ss.Close.SetActive(false);
        }
        else
        {
            MenuText.SetActive(true);
            ss.Close.SetActive(true);
        }
    }
}
