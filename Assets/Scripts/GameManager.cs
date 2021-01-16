using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject wall;
    public GameObject[] buttons;

    //Lockerのボタンを押したら、画像が変更されるようにしたい。
    //スクリプトを分けるべき？？



    public enum WALL_POS
    {
        FRONT,
        RIGHT,
        BACK,
        LEFT,
        LOCKER
    }


    WALL_POS currentWallNo;

    // Start is called before the first frame update
    void Start()
    {
        currentWallNo = WALL_POS.FRONT;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushButtonRight()
    {
        
        currentWallNo++;

        if(currentWallNo > WALL_POS.LEFT)
        {
            currentWallNo = WALL_POS.FRONT;
        }

        DisplayWall();
    }

    public void PushButtonLeft()
    {
        currentWallNo--;

        if(currentWallNo < WALL_POS.FRONT)
        {
            currentWallNo = WALL_POS.LEFT;
        }

        DisplayWall();
    }

    public void PushButtonBack()
    {
        //backボタンを押したら、Lockerのある画面に戻りたい。
        if(currentWallNo == WALL_POS.LOCKER )
        {
            currentWallNo = WALL_POS.LEFT;

            wall.transform.localPosition = new Vector3(-3000.0f, 0.0f, 0.0f);
            //backボタンを押して通常の画面に戻ったら右、左のボタンを戻したい。
            buttons[0].SetActive(true);
            buttons[1].SetActive(true);
        }

    }

    void DisplayWall()
    {
        switch (currentWallNo)
        {
            case WALL_POS.FRONT:
                wall.transform.localPosition= new Vector3(0.0f, 0.0f, 0.0f);
                break;
            case WALL_POS.RIGHT:
                wall.transform.localPosition= new Vector3(-1000.0f, 0.0f, 0.0f);
                break;
            case WALL_POS.BACK:
                wall.transform.localPosition = new Vector3(-2000.0f, 0.0f, 0.0f);
                break;
            case WALL_POS.LEFT:
                wall.transform.localPosition = new Vector3(-3000.0f, 0.0f, 0.0f);
                break;
        }
    }

    public void PushButtonLocker()
    {
        currentWallNo = WALL_POS.LOCKER;
        wall.transform.localPosition = new Vector3(-4000.0f, 0.0f, 0.0f);
        //zoomしたら、横のボタンは不要なので消しておきたい。
        buttons[0].SetActive(false);
        buttons[1].SetActive(false);
    }
}
