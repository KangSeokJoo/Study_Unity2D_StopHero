using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    //묵 = 0, 찌 = 1, 빠 = 2
    //0 = draw, 1 = win, 2 = fail

    string colname;
    public Sprite[] rsp;
    public GameObject EndPanel, minigamePanel, box;
    public int check = -1;
    int r, userpick;
    bool pick = false;
    public bool workCheck, timeCheck = true;
    public Text result;
    public static GM instance;

    void Start()
    {

    }

    private void Awake()
    {
        if (GM.instance == null)
        {
            GM.instance = this;
        }
    }

    // Update is called once per frame
    void Update () {

        if (workCheck == true)
        { // 미니게임이 끝나면 스크립트 비활성화를 풀겠다.
            GameObject.Find("Player").GetComponent<PlayerManager>().enabled = true;
        }
        if (timeCheck == true)
            GameObject.Find("UI").GetComponent<InterfaceUI>().enabled = true;
    }

    public void minigameStart()
    {
        workCheck = false;
        timeCheck = false;
        if(workCheck == false)
        {
            GameObject.Find("UI").GetComponent<InterfaceUI>().enabled = false;
        }
        minigamePanel.SetActive(true);
    }

    void miniGameGo()
    {
        r = Random.Range(0, 3);

        switch (userpick)
        {
            case 0:
                if (r == 0)
                {
                    result.text = "Draw";
                    check = 0;
                }
                else if (r == 1)
                {
                    result.text = "Win";
                    check = 1;
                }
                else if (r == 2)
                {
                    result.text = "Fail";
                    check = 2;
                }
                break;

            case 1:
                if (r == 0)
                {
                    result.text = "Fail";
                    check = 2;
                }
                else if (r == 1)
                {
                    result.text = "Draw";
                    check = 0;
                }
                else if (r == 2)
                {
                    result.text = "Win";
                    check = 1;
                }
                break;

            case 2:
                if (r == 0)
                {
                    result.text = "Win";
                    check = 1;
                }
                else if (r == 1)
                {
                    result.text = "Fail";
                    check = 2;
                }
                else if (r == 2)
                {
                    result.text = "Draw";
                    check = 0;
                }
                break;
        }

        print(r);
        print(check);

        changeImg(r);

    }

    void changeImg(int i)
    {
        switch (i)
        {
            case 0 :
                box.GetComponent<Image>().sprite = rsp[0];
                break;
            case 1:
                box.GetComponent<Image>().sprite = rsp[1];
                break;
            case 2:
                box.GetComponent<Image>().sprite = rsp[2];
                break;
        }

        if (check > -1)
            Invoke("Result", 0.5f);
    }

    public void Rock()
    {
        if (pick == false)
        {
            userpick = 0;
            pick = true;
            Invoke("miniGameGo", 1.5f);
        }
        else
            return;
    }

    public void Scissors()
    {
        if (pick == false)
        {
            userpick = 1;
            pick = true;
            Invoke("miniGameGo", 1.5f);
        }
        else
            return;
    }

    public void Paper()
    {
        if (pick == false)
        {
            userpick = 2;
            pick = true;
            Invoke("miniGameGo", 1.5f);
        }
        else
            return;
    }

    void Result()
    {
        EndPanel.SetActive(true);
        Invoke("End", 2.5f);
    }

    void End()
    {
        EndPanel.SetActive(false);
        minigamePanel.SetActive(false);
        pick = false;
        workCheck = true;
        timeCheck = true;
        box.GetComponent<Image>().sprite = rsp[3];

        GameObject.Find("GM").GetComponent<collision>().Amends(colname, check);
        print(workCheck);
    }

    public void Gettag(string s)
    {
        colname = s;
    }
}
