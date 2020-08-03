using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class MenuButtonScript : MonoBehaviour
{
    public GameObject MenuText;

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
        Debug.Log("a");
        if (MenuText.active)
        {
            MenuText.SetActive(false);
        }
        else
        {
            MenuText.SetActive(true);
        }
    }
}
