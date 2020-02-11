using UnityEngine;
using System.Collections;

public class AuraStage : MonoBehaviour {

    public GameObject Glowing;

	// Use this for initialization
	void Start () {

        Glowing.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col) {

        if (col.gameObject.name == "Pointer")
        {
            Glowing.SetActive(true);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {

        if (col.gameObject.name == "Pointer")
        {
            Glowing.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.name == "Pointer")
        {
            Glowing.SetActive(false);
        }
    }
}
