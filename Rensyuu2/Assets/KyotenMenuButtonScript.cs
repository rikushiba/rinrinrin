using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyotenMenuButtonScript : MonoBehaviour
{
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
        if (ss.MenuText.activeSelf || ss.MapMenu.activeSelf)
        {
            ss.MapMenu.SetActive(false);
            ss.MenuText.SetActive(false);
            ss.Close.SetActive(false);
        }
        else if (ss.Tenkuu.activeSelf && ss.Frame2.activeSelf)
        {

        }
        else
        {
            ss.MenuText.SetActive(true);
            ss.Close.SetActive(true);
        }
    }
}
