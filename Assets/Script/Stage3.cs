using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3 : MonoBehaviour {

//5.28
	void Start () {
        LastFail.instance.Update();
	}
	void Update () {


        if (transform.position.x > -2.51f && transform.position.x < 0.552f) // 맵 왼쪽
        {
            if (transform.position.x == -2.5f)
            {
                PlayerManager.instance.upMoveStop = false;
                if (transform.position.y > 5.28f)
                {
                    PlayerManager.instance.upMoveStop = true;
                    PlayerManager.instance.rightMoveStop = false;
                }
            }

            if (transform.position.x > -0.66f && transform.position.y > 5.26f
                && transform.position.x < -0.63f)
            {
                PlayerManager.instance.rightMoveStop = true;
                PlayerManager.instance.downMoveStop = false;
            }
            if (transform.position.x > -0.67f && transform.position.x < -0.62f
                && transform.position.y < 4f && transform.position.y > 3.9f)
            {
                PlayerManager.instance.downMoveStop = true;
                PlayerManager.instance.leftMoveStop = false;
            }
            if (transform.position.x < -1.88f && transform.position.x > -2.0f
                && transform.position.y < 4f)
            {
                PlayerManager.instance.leftMoveStop = true;
                PlayerManager.instance.downMoveStop = false;
            }
            if (transform.position.y < 2.55f && transform.position.x < -1.88f
                && transform.position.x > -1.92f && transform.position.y > 2.5f)
            {
                PlayerManager.instance.downMoveStop = true;
                PlayerManager.instance.rightMoveStop = false;
            }
            if (transform.position.x > -0.66f && transform.position.y < 2.55f
                && transform.position.x < -0.63f && transform.position.y > 2.53f)
            {
                PlayerManager.instance.rightMoveStop = true;
                PlayerManager.instance.downMoveStop = false;
            }
            if (transform.position.x > -0.66f && transform.position.x < -0.63f
                && transform.position.y < 1.25f && transform.position.y > 1.23f)
            {
                PlayerManager.instance.downMoveStop = true;
                PlayerManager.instance.leftMoveStop = false;
            }
            if (transform.position.x > -1.92f && transform.position.x < -1.88f
               && transform.position.y < 1.25f && transform.position.y > 1.23f)
            {
                PlayerManager.instance.leftMoveStop = true;
                PlayerManager.instance.downMoveStop = false;
            }
            if (transform.position.x < 0.52f && transform.position.x > -1.9f
                && transform.position.y < 0.2f)
            {
                PlayerManager.instance.downMoveStop = true;
                PlayerManager.instance.rightMoveStop = false;
            }

            if(transform.position.x > 0.53f)
            {
                PlayerManager.instance.rightMoveStop = true;
            }
        }

        if(transform.position.y < 5.28f && transform.position.x < 0.56f
            && transform.position.x > 0.531f)
        {
            PlayerManager.instance.upMoveStop = false;
        }
        if(transform.position.y > 5.28f && transform.position.x > 0.53
            && transform.position.x < 2.41f)
        {
            PlayerManager.instance.upMoveStop = true;
            PlayerManager.instance.rightMoveStop = false;
        }
        if(transform.position.y > 5.28f && transform.position.x > 2.41f)
        {
            PlayerManager.instance.rightMoveStop = true;
            PlayerManager.instance.downMoveStop = false;
        }
        if(transform.position.y < 4f && transform.position.x < 2.45f
            && transform.position.x > 1.12f && transform.position.y > 3.88f)
        {
            PlayerManager.instance.downMoveStop = true;
            PlayerManager.instance.leftMoveStop = false;
        }
        if(transform.position.x < 1.12f && transform.position.y > 3.78f
            && transform.position.y < 4f && transform.position.x > 1f)
        {
            PlayerManager.instance.leftMoveStop = true;
            PlayerManager.instance.downMoveStop = false;
        }

        if(transform.position.y < 2.68f && transform.position.y > 2.5f
            && transform.position.x > 1.08f && transform.position.x < 2.45f)
        {
            PlayerManager.instance.downMoveStop = true;
            PlayerManager.instance.rightMoveStop = false;
        }

        if(transform.position.x > 2.45f && transform.position.y > 2.5f
            &&transform.position.y < 2.68f)
        {
            PlayerManager.instance.rightMoveStop = true;
            PlayerManager.instance.downMoveStop = false;
        }

        if(transform.position.x < 2.468f && transform.position.y > 1.63f
            && transform.position.y <1.65f && transform.position.x > 1.12f)
        {
            PlayerManager.instance.downMoveStop = true;
            PlayerManager.instance.leftMoveStop = false;
        }
        if(transform.position.x > 1.08f && transform.position.y > 1.63f
            && transform.position.y <1.65f && transform.position.x < 1.2f)
        {
            PlayerManager.instance.leftMoveStop = true;
            PlayerManager.instance.downMoveStop = false;
        }
        if(transform.position.x <1.2f && transform.position.y > 0.19f
            &&transform.position.y < 0.22f && transform.position.x > 1.08f)
        {
            PlayerManager.instance.downMoveStop = true;
            PlayerManager.instance.rightMoveStop = false;
        }
    }
}
