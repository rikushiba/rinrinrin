using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpbuttonScript : MonoBehaviour
{
    public GameObject frame;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        frame.transform.Translate(0, 1, 0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
