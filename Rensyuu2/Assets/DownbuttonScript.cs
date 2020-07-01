using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownbuttonScript : MonoBehaviour
{
    public GameObject frame;
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
        frame.transform.Translate(0, -1, 0);
    }
}
