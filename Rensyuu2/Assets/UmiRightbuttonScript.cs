﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmiRightbuttonScript : MonoBehaviour
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
        if (MenuText.active)
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
