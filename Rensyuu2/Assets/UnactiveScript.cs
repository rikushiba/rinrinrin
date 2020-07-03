using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnactiveScript : MonoBehaviour
{
    GameObject frame2;
    GameObject KyotenTenkuu;
    GameObject Close;
    // Start is called before the first frame update
    void Start()
    {
        frame2 = GameObject.Find("frame2");
        KyotenTenkuu = GameObject.Find("KyotenTenkuu");
        Close = GameObject.Find("Close");
        frame2.SetActive(false);
        KyotenTenkuu.SetActive(false);
        Close.SetActive(false);
    }
    public void Onactive()
    {
        frame2.SetActive(true);
        KyotenTenkuu.SetActive(true);
        Close.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
