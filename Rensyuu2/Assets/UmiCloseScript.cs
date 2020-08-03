using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmiCloseScript : MonoBehaviour
{
    public GameObject MenuText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MenuText.active)
        {
        }
        else
        {
            MenuText.SetActive(true);
        }
    }
}
