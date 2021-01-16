using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockerManager : MonoBehaviour
{
    //Lockerボタンを押したら、画像を変更したい。

    //１．Lockerのマークボタンを押したとき。
    //2. 画像を変更する。


    //現在表示されている画像を取得。
    public Image[] currentImages;
    //変更する画像を取得。

    public Sprite[] markImages;

    //変更した際にマーク変数で管理する。
    public enum MARK_IMAGES
    {
        Maru,
        Sankaku,
        Hoshi,
        Daia
    }

    MARK_IMAGES currentMark = MARK_IMAGES.Maru;
    //プロパティもUnityのオブジェクト毎に独立している。
    //オブジェクトでスクリプトが一緒でもプロパティは独立しているので、
    //currentMark++になってもそのオブジェクトのcurrentMarkプロパティが
    //+1されているだけ。他のオブジェクトのプロパティが+1されているわけ
    //ではない。

    public void PushMarkButton(int index)
    {
        Debug.Log(index + "push!!!");

        currentMark++;
        if(currentMark > MARK_IMAGES.Daia)
        {
            currentMark = MARK_IMAGES.Maru;
        }


        currentImages[index].sprite = GetSource();
    }

    Sprite GetSource()
    {
        switch (currentMark)
        {
            case MARK_IMAGES.Maru:
                return markImages[0];
                break;
            case MARK_IMAGES.Sankaku:
                return markImages[1];
                break;
            case MARK_IMAGES.Hoshi:
                return markImages[2];
                break;
            case MARK_IMAGES.Daia:
                return markImages[3];
                break;
        }
        return null;
    }
}
