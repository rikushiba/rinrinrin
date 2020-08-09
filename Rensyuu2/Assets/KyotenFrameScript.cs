using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyotenFrameScript : MonoBehaviour
{
    Vector3 Mposition;
    Vector3 Obp;
    Vector3 screenToWorldPointPosition;

    GameObject send;
    SendScript ss;
    GameObject Close;
    GameObject Frame;
    GameObject Frame2;
    GameObject KT;
    Transform ObTransform;

    private void Awake()
    {
        send = GameObject.Find("Send");
    }
    // Start is called before the first frame update
    void Start()
    {
        ss = send.GetComponent<SendScript>();
        Close = ss.Close;
        Frame = ss.Frame;
        Frame2 = ss.Frame2;
        KT = ss.Tenkuu;

        ObTransform = this.transform;
        Obp = ObTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Close.activeSelf)
        {

        }
        else
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
}
