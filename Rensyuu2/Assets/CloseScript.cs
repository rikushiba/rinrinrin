using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseScript : MonoBehaviour
{
    public GameObject Grid;
    public GameObject Close;
    public GameObject Frame2;
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
        Grid.SetActive(false);
        Close.SetActive(false);
        Frame2.SetActive(false);
    }
}
