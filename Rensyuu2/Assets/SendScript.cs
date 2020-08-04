using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Threading;
using UnityEngine.UI;
public class SendScript : MonoBehaviour
{
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

    public GameObject Frame;
    public GameObject Frame2;
    public GameObject Close;
    public GameObject Select;
    public GameObject Menu;
    public Color SelectedTextColor = new Color(1.0f, 0.0f, 0.0f, 1.0f);
    public Color UnselectedTextColor = new Color(0.0f, 0.0f, 0.0f, 1.0f);

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
        
    }
}
