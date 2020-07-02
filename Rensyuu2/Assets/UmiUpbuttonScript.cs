using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmiUpbuttonScript : MonoBehaviour
{
    GameObject frame;
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
