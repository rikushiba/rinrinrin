using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UmiSelectScript : MonoBehaviour
{
    public GameObject MenuText;
    public GameObject MapMenu;
    public GameObject Map;
    public GameObject Yama;
    public GameObject Kyoten;
    Text MapText;
    Text YamaText;
    Text KyotenText;
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
        MapText = Map.GetComponent<Text>();
        YamaText = Yama.GetComponent<Text>();
        KyotenText = Kyoten.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickAct()
    {
        if (MenuText.activeSelf)
        {
            if (MapText.color == ss.SelectedTextColor)
            {
                MenuText.SetActive(false);
                MapMenu.SetActive(true);
            }
        }
        else if (MapMenu.activeSelf){
            if(YamaText.color == ss.SelectedTextColor)
            {
                SceneManager.LoadScene("Ymascene");
            }
            else if(KyotenText.color == ss.SelectedTextColor)
            {
                SceneManager.LoadSceneAsync("KyotenScene");
            }
        }
    }
}
