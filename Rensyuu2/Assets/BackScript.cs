using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BackScript : MonoBehaviour
{
    GameObject send;
    SendScript ss;

    private void Awake()
    {
        send = GameObject.Find("Send");
    }
    // Start is called before the first frame update
    void Start()
    {
        ss = send.GetComponent<SendScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickAct()
    {
        if (ss.Tenkuu.activeSelf && ss.Frame2.activeSelf )          
        {
            ss.MenuText.SetActive(true);
            ss.Tenkuu.SetActive(false);
            ss.Frame2.SetActive(false);
            ss.Back.SetActive(false);         
        }
        else if (!(ss.Tenkuu.activeSelf) && !(ss.Frame2.activeSelf) && !(ss.MapMenu.activeSelf))
        {
            ss.Tenkuu.SetActive(true);
            ss.Frame2.SetActive(true);
            ss.Close.SetActive(true);
        } 
        else if (ss.MapMenu.activeSelf)
        {
            ss.MapMenu.SetActive(false);
            ss.MenuText.SetActive(true);
            ss.Back.SetActive(false);
        }
    }
}
