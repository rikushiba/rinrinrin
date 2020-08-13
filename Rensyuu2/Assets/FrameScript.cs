using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameScript : MonoBehaviour
{
    Vector3 Mposition;
    Vector3 Obp;
    Vector3 screenToWorldPointPosition;
    GameObject frame;
    Transform ObTransform;
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
        frame = GameObject.Find("frame");
        ObTransform = this.transform;
        Obp = ObTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (ss.MenuText.activeSelf || ss.MapMenu.activeSelf || ss.Yes.activeSelf || ss.No.activeSelf || (ss.Tenkuu.activeSelf && ss.Close.activeSelf && ss.Frame2.activeSelf) || ss.BouekiMenu.activeSelf)
        {

        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Mposition = Input.mousePosition;
                Mposition.z = 20f;
                screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(Mposition);
                if (-14 <= screenToWorldPointPosition.x && screenToWorldPointPosition.x <= 6 && -9 <= screenToWorldPointPosition.y && screenToWorldPointPosition.y <= 11)
                {
                    Obp.x = (Mathf.Ceil(screenToWorldPointPosition.x) + Mathf.Floor(screenToWorldPointPosition.x)) / 2;
                    Obp.y = (Mathf.Ceil(screenToWorldPointPosition.y) + Mathf.Floor(screenToWorldPointPosition.y)) / 2;
                    ObTransform.position = Obp;
                }
            }
        }
    }
}
