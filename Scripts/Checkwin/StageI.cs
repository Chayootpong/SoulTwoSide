using UnityEngine;
using System.Collections;

public class StageI : MonoBehaviour {

    public static int winone;

	// Use this for initialization
	void Start () {

        winone = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Condition.checkwin == 1) {

            winone = 1;
        }
	
	}
}
