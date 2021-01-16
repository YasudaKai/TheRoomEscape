using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public GameObject[] boxItems;
    

    public static ItemBox instance;
    void Awake()
    {
        instance = this;
    }

    public void SetItem(Item.Type type)
    {
        //アイテムボックスにアイテムをセットする。
        switch (type)
        {
            case Item.Type.Key:
                boxItems[0].SetActive(true);
                break;
            case Item.Type.Panda:
                boxItems[1].SetActive(true);
                break;
        }
    }

    public bool CanUseItem(Item.Type type)
    {
        if (type == Item.Type.Key)
        {
            return boxItems[0].activeSelf;
        }
        if (boxItems[1].activeSelf)
        {
            return true;
        }
        return false;
    }
    
}
