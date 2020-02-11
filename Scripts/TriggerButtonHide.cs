using UnityEngine;
using System.Collections;

public class TriggerButtonHide : MonoBehaviour {

    public GameObject rift;

	// Use this for initialization
	void Start () {

        rift.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        

            rift.SetActive(true);

        
    }

    void OnTriggerStay2D(Collider2D col)
    {
        

            rift.SetActive(true);

        
    }

    void OnTriggerExit2D(Collider2D col)
    {
        
            rift.SetActive(false);

        
    }
}
