using UnityEngine;
using System.Collections;

public class StageII : MonoBehaviour {

    public static int wintwo;

	// Use this for initialization
	void Start () {

        wintwo = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Condition.checkwin == 1)
        {

            wintwo = 1;
        }

    }
}
