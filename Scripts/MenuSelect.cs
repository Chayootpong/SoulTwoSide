using UnityEngine;
using System.Collections;

public class MenuSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Blue_P1")) {

            Application.Quit();
        }

        if (Input.GetButtonDown("Red_P1"))
        {

            Application.LoadLevel("Stage");
        }

    }
}
