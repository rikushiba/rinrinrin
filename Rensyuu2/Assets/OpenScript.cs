﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript : MonoBehaviour
{
    public GameObject Grid;
    public GameObject Close;
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
        Grid.SetActive(true);
        Close.SetActive(true);
    }
}