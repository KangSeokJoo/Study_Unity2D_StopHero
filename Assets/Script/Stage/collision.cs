using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    float time = 3;
    float timer = 0;
    bool aniCheck = false;
    GameObject player;
    Animator ani;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        ani = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void Amends(string tag, int result)
    {
        print(tag);
        print(result);

        if (tag == "Boom")
        {
            switch (result)
            {
                case 0:
                    return;
                case 1:
                    Attack();
                    break;
                case 2:
                    buff();
                    break;
            }
        }
        else if (tag == "Sawp")
        {
            switch (result)
            {
                case 0:
                    return;
                case 1:
                    Debuff();
                    break;
                case 2:
                    buff();
                    break;
            }
        }
    }

    void Debuff()
    {
        if (player.GetComponent<PlayerManager>().yspeed > 0.1f && player.GetComponent<PlayerManager>().xspeed > 0.1f)
        {
            player.GetComponent<PlayerManager>().xspeed -= 0.2f;
            player.GetComponent<PlayerManager>().yspeed -= 0.2f;
        }
        else
            return;
    }

    void buff()
    {   
            player.GetComponent<PlayerManager>().xspeed += 0.2f;
            player.GetComponent<PlayerManager>().yspeed += 0.2f;
    }

    void Attack()
    {
        GameObject.Find("GM").GetComponent<GM>().workCheck = false;
        ani.SetBool("attack", true);
        Invoke("Solve", 3);

    }

    void Solve()
    {
        ani.SetBool("attack", false);
        GameObject.Find("GM").GetComponent<GM>().workCheck = true;
        print(GameObject.Find("GM").GetComponent<GM>().workCheck);
    }
}
