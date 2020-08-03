using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseScript : MonoBehaviour
{
    public GameObject Grid;
    GameObject send;
    SendScript sendscript;
    GameObject Close;
    GameObject Frame2;

    private void Awake()
    {
        send = GameObject.Find("Send");
    }
    // Start is called before the first frame update
    void Start()
    {
        sendscript = send.GetComponent<SendScript>();
        Close = sendscript.close;
        Frame2 = sendscript.frame2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickAct()
    {
        Grid.SetActive(false);
        Close.SetActive(false);
        Frame2.SetActive(false);
    }
}
