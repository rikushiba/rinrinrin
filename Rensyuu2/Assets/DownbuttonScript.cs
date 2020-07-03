using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class DownbuttonScript : MonoBehaviour
{
    GameObject frame;
    GameObject frame2;
    // Start is called before the first frame update
    void Start()
    {
        frame = GameObject.Find("frame");
        frame2 = GameObject.Find("frame2");
    }

    // Update is called once per frame
    void Update()
    {
        
 }
    public void onClickAct()
    {
        if (frame2.active)
        {
            if (frame2.transform.position.y >-9)
            {
                frame2.transform.Translate(0, -2, 0);
            }

        }
        else
        {
            if (frame.transform.position.y > -9)
            {
                frame.transform.Translate(0, -1, 0);
            }
        }
    }
}
