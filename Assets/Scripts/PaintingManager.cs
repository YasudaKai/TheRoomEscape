using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintingManager : MonoBehaviour
{
    public GameObject wall;

    public Image[] currentPainting;
    //GetComponentで画像変更処理できるか？
    //Imageクラスを使わずに。
    public Sprite[] changeOukan;
    public Sprite[] changeKubiwa;
    public Sprite[] changeUdewa;

    //王冠、首輪、指輪ごとに番号分けた方が良い？？

    public const int oukan = 0;
    public const int kubiwa = 1;
    public const int udewa = 2;


    enum MARK_OUKAN
    {
        Red,
        Green,
        Yellow
    }

    enum MARK_KUBIWA
    {
        Purple,
        Red,
        Yellow
    }

    enum MARK_UDEWA
    {
        Orange,
        Green,
        Purple
    }

    MARK_OUKAN currentOukan = MARK_OUKAN.Red;
    MARK_KUBIWA currentKubiwa = MARK_KUBIWA.Purple;
    MARK_UDEWA currentUdewa = MARK_UDEWA.Orange;

    //絵画の画像をタッチしたら、絵画をアップにしたい。
    //その絵画の画像をタッチすると画像を変更したい。
    //1．絵画をタッチした時
    //2.絵画のアップ画像を表示
    //3．絵画をタッチ
    //4．絵画の画像を変更

    public void TouchPainting()
    {
        Debug.Log("touch");
        wall.transform.localPosition = new Vector2(-5000.0f, 0.0f);
    }

    //どの絵画にタッチしたか
    //現在の画像を取得
    //変更する画像を取得
    //現在どの画像なのかをマーク変数で管理する。


    public void ChangePainting(int paintingNumber)
    {
        Debug.Log(paintingNumber + "change!!");

        
        switch (paintingNumber)
        {
            case oukan:
                ChangeOukan();
                break;
            case kubiwa:
                ChangeKubiwa();
                break;
            case udewa:
                ChangeUdewa();
                break;
        }
    }

    public void ChangeOukan()
    {
        //王冠の画像を変更する
        currentOukan++;
        if(currentOukan > MARK_OUKAN.Yellow)
        {
            currentOukan = MARK_OUKAN.Red;
        }

        currentPainting[oukan].sprite = GetOukan();
    }

    //首輪の画像を変更する
    public void ChangeKubiwa()
    {
        currentKubiwa++;
        if (currentKubiwa > MARK_KUBIWA.Yellow)
        {
            currentKubiwa = MARK_KUBIWA.Purple;
        }

        currentPainting[kubiwa].sprite = GetKubiwa();
    }

    //腕輪の画像を変更する
    public void ChangeUdewa()
    {
        currentUdewa++;
        if (currentUdewa > MARK_UDEWA.Purple)
        {
            currentUdewa = MARK_UDEWA.Orange;
        }

        currentPainting[udewa].sprite = GetUdewa();
    }

    Sprite GetOukan()
    {
        switch (currentOukan)
        {
            case MARK_OUKAN.Red:
                return changeOukan[0];
                break;
            case MARK_OUKAN.Green:
                return changeOukan[1];
                break;
            case MARK_OUKAN.Yellow:
                return changeOukan[2];
                break;
        }
        return null;
    }

    Sprite GetKubiwa()
    {
        switch (currentKubiwa)
        {
            case MARK_KUBIWA.Purple:
                return changeKubiwa[0];
                break;
            case MARK_KUBIWA.Red:
                return changeKubiwa[1];
                break;
            case MARK_KUBIWA.Yellow:
                return changeKubiwa[2];
                break;
        }
        return null;
    }

    Sprite GetUdewa()
    {
        switch (currentUdewa)
        {
            case MARK_UDEWA.Orange:
                return changeUdewa[0];
                break;
            case MARK_UDEWA.Green:
                return changeUdewa[1];
                break;
            case MARK_UDEWA.Purple:
                return changeUdewa[2];
                break;
        }
        return null;
    }


}
