using UnityEngine;
using System.Collections;

public class RevOut : MonoBehaviour {

    private Animator anim;
    public bool check;
    public GameObject box;

    // Use this for initialization
    void Start () {

        check = false;
        anim = gameObject.GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {

        anim.SetBool("Bool", check);

        if (TriggerOut.trig == true)
        {
            check = true;
            Destroy(box);
        }
	
	}
}
