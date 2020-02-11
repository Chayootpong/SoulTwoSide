using UnityEngine;
using System.Collections;

public class TriggerOut : MonoBehaviour {

    public static bool trig;

	// Use this for initialization
	void Start () {

        trig = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        trig = true;
        Destroy(gameObject);
    }
}
