using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmiLeftbuttonScript : MonoBehaviour
{
    GameObject frame;
    public GameObject MenuText;
    // Start is called before the first frame update
    void Start()
    {
        frame = GameObject.Find("frame");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickAct()
    {
        if (MenuText.activeSelf)
        {

        }
        else
        {
            if (frame.transform.position.x > -13)
            {
                frame.transform.Translate(-1, 0, 0);
            }
            else
            {
                frame.transform.Translate(0, 0, 0);
            }
        }
    }
}
