using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class RightbuttonScript : MonoBehaviour
{
  public GameObject frame;
   public GameObject frame2;
    

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
        if (frame2.active)
        {
            if (frame2.transform.position.x < 9)
            {
                frame2.transform.Translate(2, 0, 0);
            }

        }
        else
        {
            if (frame.transform.position.x < 9)
            {
                frame.transform.Translate(1, 0, 0);
            }
        }
    }
    
}
