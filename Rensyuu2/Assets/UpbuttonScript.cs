using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpbuttonScript : MonoBehaviour
{
   public GameObject frame;
   public GameObject frame2;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickAct()
    {
        if (frame2.activeSelf)
        {
            if (frame2.transform.position.y < -7)
            {
                frame2.transform.Translate(0, 2, 0);
            }
        }
        else
        {
            if (frame.transform.position.y < 9)
            {
                frame.transform.Translate(0, 1, 0);
            }
        
        }
    }
}
