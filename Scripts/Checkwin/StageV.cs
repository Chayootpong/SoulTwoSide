using UnityEngine;
using System.Collections;

public class StageV : MonoBehaviour {

    public static int winfive;

    // Use this for initialization
    void Start () {

        winfive = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (Condition.checkwin == 1)
        {

            winfive = 1;
        }

    }
}
