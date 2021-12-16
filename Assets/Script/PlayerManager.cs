using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    public float xspeed;
    public float yspeed;
    public bool leftMoveStop = true;
    public bool rightMoveStop = true;
    public bool upMoveStop = true;
    public bool downMoveStop = true;
    public static PlayerManager instance;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    

    // Update is called once per frame
    public void Update()
    {
        {
            if (rightMoveStop == false)
            { // 거짓일때 움직인다
                transform.Translate(Vector2.right * Time.deltaTime * xspeed);
            }
            if (leftMoveStop == false)
            {
                transform.Translate(Vector2.left * Time.deltaTime * xspeed);

            }
            if (upMoveStop == false)
            { // 똑같이 거짓일때 움직인다.
                transform.Translate(Vector2.up * Time.deltaTime * yspeed);
            }
            if (downMoveStop == false)
            {
                transform.Translate(Vector2.down * Time.deltaTime * yspeed);
            }
        }

        /* x축으로 어느정도 가면 위로 올라가게 할라했지만,
         에너미한테 부딪혔을때 뒤로가고 나서 바로 위로 올라가면 화면밖에서도 올라갈 가능성 있음
         그래서 고정값으로 줌 3.18x */
        if (transform.position.x > 3.18f)
        {
            gameObject.SetActive(false);
        }

        if (GameObject.Find("GM").GetComponent<GM>().workCheck == false)
            // gm에서 워크체크가 미니게임 스타트할때 펄스된다.
           // 그래서 이때 펄스라면 스테이지 이동 스크립트를 잠시 비활성화하겠다.
        {
            gameObject.GetComponent<PlayerManager>().enabled = false;

        } 
        //콜렙용 주석
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "flag")
            SceneManager.LoadScene("Fail");
        if (collision.tag == "Boom")
            GameObject.Find("GM").GetComponent<GM>().Gettag(collision.tag);
        else if(collision.tag == "Sawp")
            GameObject.Find("GM").GetComponent<GM>().Gettag(collision.tag);
    }
}