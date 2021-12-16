using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerManager.instance.Update();
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x < 3.18f && transform.position.y == 1f)
        {
            PlayerManager.instance.rightMoveStop = false;
        }
        if (transform.position.x > 3.18f && transform.position.y == 1f)
        {
            PlayerManager.instance.rightMoveStop = true;
        }
    }


}
