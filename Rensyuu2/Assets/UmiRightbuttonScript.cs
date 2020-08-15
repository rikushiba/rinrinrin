using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmiRightbuttonScript : MonoBehaviour
{
    GameObject frame;
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
        frame = GameObject.Find("frame");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickAct()
    {
        if (ss.Yes.activeSelf)
        {
            ss.YesOrNo();
        }
        else if (ss.Frame2.activeSelf)
        {
            if (ss.Frame2.transform.position.x < 3)
            {
                ss.Frame2.transform.Translate(4, 0, 0);
            }

        }
        else if (ss.MenuText.activeSelf || ss.MapMenu.activeSelf || ss.BouekiMenu.activeSelf || ss.YusyutsuMenu.activeSelf
            || ss.YunyuMenu.activeSelf)
        {
        
        }     
        else 
        { 
            if (frame.transform.position.x < 5)
            {
                frame.transform.Translate(1, 0, 0);
            }
            else
            {
                frame.transform.Translate(0, 0, 0);
            }
        }
    }
}
