using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Yellow_P1"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetButtonDown("Yellow_P2"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetButtonDown("Red_P1"))
        {
            Application.LoadLevel("Stage");
        }

        if (Input.GetButtonDown("Red_P2"))
        {
            Application.LoadLevel("Stage");
        }

        if (Input.GetButtonDown("Blue_P1"))
        {
            if (Condition.checkwin == 1)
            {
                Application.LoadLevel(Application.loadedLevel + 1);
            }

        }

        if (Input.GetButtonDown("Blue_P2"))
        {

            if (Condition.checkwin == 1)
            {
                Application.LoadLevel(Application.loadedLevel + 1);
            }

        }

    }
}
