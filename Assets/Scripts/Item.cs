using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum Type
    {
        Key,
        Panda,
    }

    public Type type;
    

    public void OnThis()
    {
        Debug.Log("keyがクリックされた！！");
        Debug.Log(type + "を取得した！！");
        gameObject.SetActive(false);
        ItemBox.instance.SetItem(type);
    }

    

    //ドアをクリックしてgameObject.SetAcitive(false)など
    //する必要がないので、ドアクリックする関数は別で作成する。
    public void OnClickDoor()
    {
        bool hasItem = ItemBox.instance.CanUseItem(type);
        if(hasItem == true)
        {
            Debug.Log("GameClear!!!");
        }
        else
        {
            Debug.Log("Keyを持っていないので扉は開かない。");
        }
    }
}
