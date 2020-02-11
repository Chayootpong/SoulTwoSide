using UnityEngine;
using System.Collections;

public class TriggerButton2 : MonoBehaviour {

    public GameObject rift;
    public static int check;

	// Use this for initialization
	void Start () {

        check = 0;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        check = 1;
        rift.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D col)
    {
        check = 1;
        rift.SetActive(false);
    }

    void OnTriggerExit2D(Collider2D col)
    {

        check = 2;
        rift.SetActive(true);

    }
}
