﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YamaFrameScript : MonoBehaviour
{
    Vector3 Mposition;
    Vector3 Obp;
    Vector3 screenToWorldPointPosition;
    GameObject frame;
    Transform ObTransform;
    // Start is called before the first frame update
    void Start()
    {
        frame = GameObject.Find("frame");
        ObTransform = this.transform;
        Obp = ObTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Mposition = Input.mousePosition;
            Mposition.z = 20f;
            screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(Mposition);
            if (-10 <= screenToWorldPointPosition.x && screenToWorldPointPosition.x <= 10 && -10 <= screenToWorldPointPosition.y && screenToWorldPointPosition.y <= 10)
            {
                Obp.x = (Mathf.Ceil(screenToWorldPointPosition.x) + Mathf.Floor(screenToWorldPointPosition.x)) / 2;
                Obp.y = (Mathf.Ceil(screenToWorldPointPosition.y) + Mathf.Floor(screenToWorldPointPosition.y)) / 2;
                ObTransform.position = Obp;
            }
        }
    }
}
