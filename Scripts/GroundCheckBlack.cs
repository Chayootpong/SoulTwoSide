using UnityEngine;
using System.Collections;

public class GroundCheckBlack : MonoBehaviour {

    private MovementBlack black;

	// Use this for initialization
	void Start () {

        black = gameObject.GetComponentInParent<MovementBlack>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col) {

        black.grounded = true;

    }

    void OnTriggerStay2D(Collider2D col)
    {

        black.grounded = true;

    }

    void OnTriggerExit2D(Collider2D col)
    {

        black.grounded = false;

    }
}
