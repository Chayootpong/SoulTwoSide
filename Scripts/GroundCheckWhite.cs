using UnityEngine;
using System.Collections;

public class GroundCheckWhite : MonoBehaviour {

    private MovementWhite white;

	// Use this for initialization
	void Start () {

        white = gameObject.GetComponentInParent<MovementWhite>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col) {

        white.grounded = true;

    }

    void OnTriggerStay2D(Collider2D col)
    {

        white.grounded = true;

    }

    void OnTriggerExit2D(Collider2D col)
    {

        white.grounded = false;

    }
}
