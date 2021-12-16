using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceUI : MonoBehaviour {

    public Text TimeText, boomMaxText;
    public GameObject CopyBox;
    public int max;
    public float time;
    bool stop;

	// Use this for initialization
	void Start () {
        
        stop = GameObject.Find("GM").GetComponent<GM>().workCheck;
        TimeText.text = time.ToString("F0") + "초 남음";
    }
	
	// Update is called once per frame
	void Update () {
        
        if (time < 0)
            SceneManager.LoadScene("Clear");

        time -= Time.deltaTime;

        TimeText.text = time.ToString("F0") + "초 남음";

        if(max > 0)
            boomMaxText.text = "배치 가능 갯수 : " + max + "개";
        else
            boomMaxText.text = "배치 가능 갯수 : " + 0 + "개";

    }

    public void maxMinus()
    {
        max--;
    }

    

}
