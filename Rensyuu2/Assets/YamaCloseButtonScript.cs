using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YamaCloseButtonScript : MonoBehaviour { 

public GameObject Grid;
GameObject send;
SendScript ss;
GameObject Close;
GameObject Frame2;
Text MText;

private void Awake()
{
    send = GameObject.Find("Send");
}
// Start is called before the first frame update
void Start()
{
    ss = send.GetComponent<SendScript>();
    Close = ss.Close;
    Frame2 = ss.Frame2;
    MText = ss.MessageText.GetComponent<Text>();
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
    ss.MenuText.SetActive(false);
    ss.MapMenu.SetActive(false);
    ss.MenuText.SetActive(false);
    ss.No.SetActive(false);
    ss.Yes.SetActive(false);
    ss.Key = 0;
    MText.text = "";
}
}
