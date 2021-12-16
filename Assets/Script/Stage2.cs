using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        PlayerManager.instance.Update();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 0.25f && transform.position.x == -2.5f
            && transform.position.y < 1.01f)
        {
            PlayerManager.instance.downMoveStop = false;
        }

        if (transform.position.y < 0.25f && PlayerManager.instance.downMoveStop == false)
        // 너는 맨 밑칸마다 호출 될꺼야 그러니까 한번만써도 된다.
        {
        PlayerManager.instance.downMoveStop = true;
        }

        if (transform.position.x < -1.0f && transform.position.x > -2.51f
            && transform.position.y < 0.25f)
        {
            PlayerManager.instance.rightMoveStop = false;
            
            if(transform.position.x > -1.1f)
            {
                PlayerManager.instance.rightMoveStop = true;
            }
        }
        
        if (transform.position.x > -1.1f && transform.position.x < -1.083f)
        {
            PlayerManager.instance.upMoveStop = false;
            
            if(transform.position.y > 5.25f)
            {
                PlayerManager.instance.upMoveStop = true;
                PlayerManager.instance.rightMoveStop = false;
            }
        }

        if(transform.position.x < 0.28f && transform.position.y < 5.27f
            && transform.position.x > 0.25f)
        {
            PlayerManager.instance.rightMoveStop = true;
            PlayerManager.instance.downMoveStop = false;

            if (transform.position.y < 0.25f && PlayerManager.instance.downMoveStop == false)
            // 너는 맨 밑칸마다 호출 될꺼야 그러니까 한번만써도 된다 . + 안돼서 다시호출 디버그 해봄
            {
                PlayerManager.instance.downMoveStop = true;
            }
        }

        if (transform.position.x > 0.248f && transform.position.x < 1.62f
            && transform.position.y < 0.26f)
        {
            PlayerManager.instance.rightMoveStop = false;

            if (transform.position.x > 1.6f && transform.position.y < 5.26f)
            {
                PlayerManager.instance.rightMoveStop = true;
                PlayerManager.instance.upMoveStop = false;
            }
        }
        if (transform.position.y > 5.24f && transform.position.x > 1.6f)
        {
            PlayerManager.instance.upMoveStop = true;
            PlayerManager.instance.rightMoveStop = false;
        }
        if( transform.position.x > 2.5f && transform.position.y > 0.68f &&
            transform.position.y < 5.268f)
        {
            PlayerManager.instance.rightMoveStop = true;
            PlayerManager.instance.downMoveStop = false;
            if (transform.position.y < 0.8f)
            {
                PlayerManager.instance.downMoveStop = true;
                PlayerManager.instance.rightMoveStop = false;
            }
        }
    }
}
