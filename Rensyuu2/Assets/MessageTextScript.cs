using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageTextScript : MonoBehaviour
{
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
