using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpbuttonScript : MonoBehaviour
{
    GameObject frame;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        frame = GameObject.Find("frame");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickAct()
    {
        if (frame.transform.position.y < 9)
        {
            frame.transform.Translate(0, 1, 0);
        }
        else
        {
            frame.transform.Translate(0, 0, 0);
        }
    }
}
