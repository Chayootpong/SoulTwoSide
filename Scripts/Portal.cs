using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {

    public GameObject PortalOut;
    public GameObject White;
    public GameObject Black;
    Vector2 PortalB;

    // Use this for initialization
    void Start () {

        PortalB = PortalOut.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        
	
	}

    void OnTriggerEnter2D(Collider2D col) {

        if (col.gameObject.name == "White") {

            White.transform.position = PortalB;
        }

        if (col.gameObject.name == "Black")
        {

            Black.transform.position = PortalB;
        }
    }
}
