using UnityEngine;
using System.Collections;

public class StageIV : MonoBehaviour {

    public static int winfour;

    // Use this for initialization
    void Start () {

        winfour = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (Condition.checkwin == 1)
        {

            winfour = 1;
        }

    }
}
