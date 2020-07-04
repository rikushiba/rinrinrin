using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript : MonoBehaviour
{
    public GameObject Grid;
    public GameObject Close;
    public GameObject Frame2;
    // Start is called before the first frame update
    void Start()
    {
        Grid.SetActive(false);
        Close.SetActive(false);
        Frame2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickAct()
    {
        Grid.SetActive(true);
        Close.SetActive(true);
        Frame2.SetActive(true);
    }
}
