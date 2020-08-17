using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Threading;
using UnityEngine.UI;
using System.Numerics;

public class SendScript : MonoBehaviour
{
    public int Key=0; /*条件分岐に使う*/

    public TileBase UmiTile;
    public TileBase UmiTile2;
    public TileBase Nohara;
    public TileBase Nohara2;
    public TileBase DarkNohara;
    public TileBase DarkNohara2;
    public TileBase Beach;
    public TileBase Beach2;
    public TileBase Iwaba;
    public TileBase Iwaba2;
    public TileBase Tsuchi;
    public TileBase Tsuchi2;

    public TileBase Tree;
    public TileBase Tree2;
    public TileBase Tree3;
    public TileBase Tree4;
    public TileBase Tree5;
    public TileBase Tree6;
    public TileBase Tree7;
    public TileBase Tree8;
    public TileBase Rock;
    public TileBase Rock2;
    public TileBase Rock3;
    public TileBase Rock4;
    public TileBase Rock5;
    public TileBase Rock6;

    public TileBase House;
    public TileBase House2;
    public TileBase House3;
    public TileBase House4;
    public TileBase House5;

    public GameObject Tenkuu;
    public GameObject Background;
    public GameObject Building;

    public GameObject YunyuMenu;
    public GameObject YusyutsuMenu;
    public GameObject BouekiMenu;
    public GameObject MenuText;
    public GameObject MapMenu;
    public GameObject MessageText;
    public GameObject Yes;
    public GameObject No;


    public GameObject Frame;
    public GameObject Frame2;
    public GameObject Close;
    public GameObject Select;
    public GameObject Back;
    public GameObject Menu;
    public Color SelectedTextColor = new Color(1.0f, 0.0f, 0.0f, 1.0f);
    public Color UnselectedTextColor = new Color(0.0f, 0.0f, 0.0f, 1.0f);

    /*frameの座標を整数化したもの*/
    public Vector3Int FposInt;
    private UnityEngine.Vector3 Fpos;

    /*木、岩を除去するために必要な費用*/
    public int RemoveTreeCost = 100;
    public int RemoveRockCost = 100;

    /*輸出*/
    /*輸出品*/
    public string Yusyutsu1goods = "米";
    public string Yusyutsu2goods = "肉";
    public string Yusyutsu3goods = "魚";
    /*収益*/
    public int Yusyutsu1Syuueki = 100;
    public int Yusyutsu2Syuueki = 100;
    public int Yusyutsu3Syuueki = 100;


    /*輸入*/
    /*輸入費用*/
    public int Yunyu1Cost = 100;
    public int Yunyu2Cost = 100;
    public int Yunyu3Cost = 100;
    /*輸入品*/
    public string Yunyu1goods = "米";
    public string Yunyu2goods = "肉";
    public string Yunyu3goods = "魚";

    public Text[] GetList(GameObject ParentList)
    {
        int i=0;
        int Count = ParentList.transform.childCount;
        GameObject[] List = new GameObject[10];
        Text[] ListText = new Text[10];
        while (Count > i)
        {
            List[i] = ParentList.transform.GetChild(i).gameObject;
            ListText[i] = List[i].GetComponent<Text>();
            i++;
        }
        return ListText;
    }

    public void YesOrNo()
    {
        Text NT = No.GetComponent<Text>();
        Text YT = Yes.GetComponent<Text>();
        if(YT.color == SelectedTextColor) 
        { 
            YT.color = UnselectedTextColor;
            NT.color = SelectedTextColor;
        }
        else
        {
            NT.color = UnselectedTextColor;
            YT.color = SelectedTextColor;
        }
    }
    public void UpList(Text[] ListText, GameObject ParentList)
    {
        int i = 0;
        int Count = ParentList.transform.childCount;
        while (Count > i)
        {
            if (ListText[i].color == UnselectedTextColor)
            {
            }
            else if (ListText[i].color == SelectedTextColor)
            {
                ListText[i].color = UnselectedTextColor;
                if (i < Count - 1)
                {
                    ListText[i + 1].color =SelectedTextColor;
                }
                else
                {
                    ListText[0].color =SelectedTextColor;
                }
                break;
            }
            i++;
        }
    }

    public void DownList(Text[] ListText, GameObject ParentList)
    {
        int i = 0;
        int Count = ParentList.transform.childCount;
        while (Count > i)
        {
            if (ListText[i].color == UnselectedTextColor)
            {
            }
            else if (ListText[i].color == SelectedTextColor)
            {
                ListText[i].color = UnselectedTextColor;
                if (i > 0)
                {
                    ListText[i - 1].color = SelectedTextColor;
                }
                else
                {
                    ListText[Count-1].color = SelectedTextColor;
                }
                break;
            }
            i++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

  
    // Update is called once per frame
    void Update()
    {
        Fpos = Frame.transform.position;
        FposInt.x = Mathf.FloorToInt(Fpos.x);
        FposInt.y = Mathf.FloorToInt(Fpos.y);
        FposInt.z = (int)Fpos.z;
    }
}
