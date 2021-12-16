using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (SceneManager.GetActiveScene().name == "Clear")
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Main");
            }
        }
	}

    public void Fail()
    {
        SceneManager.LoadScene("Main");
    }
}
