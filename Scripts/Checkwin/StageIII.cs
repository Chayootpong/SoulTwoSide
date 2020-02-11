using UnityEngine;
using System.Collections;

public class StageIII : MonoBehaviour {

    public static int winthree;

    // Use this for initialization
    void Start () {

        winthree = 0;

    }
	
	// Update is called once per frame
	void Update () {

        if (Condition.checkwin == 1)
        {

            winthree = 1;
        }

    }
}
