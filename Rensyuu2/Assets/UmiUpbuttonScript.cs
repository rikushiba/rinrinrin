using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UmiUpbuttonScript : MonoBehaviour
{
    GameObject frame;
    GameObject[] MenuList = new GameObject[10] ;
    Text[] Menu = new Text[10];
    public GameObject MenuText;
    // Start is called before the first frame update
    void Start()
    { 
        int i=0;
        int Count=MenuText.transform.childCount;
        frame = GameObject.Find("frame");
        while (Count > i)
        {
            MenuList[i] = MenuText.transform.GetChild(i).gameObject;
            Menu[i] = MenuList[i].GetComponent<Text>();
            i++;
        }
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
}
