using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmiCloseScript : MonoBehaviour
{
    public GameObject MenuText;
    public GameObject MapMenu;
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

        }
    }
    }
