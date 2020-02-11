using UnityEngine;
using System.Collections;

public class RiftSP : MonoBehaviour {

    public int growth;
    private Animator anim;
    public GameObject button;

	// Use this for initialization
	void Start () {
        
        growth = 0;
        anim = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        anim.SetInteger("Growth", growth);
        anim.SetInteger("Check", TriggerButton.check);

        if (TriggerButton.check == 1)
        {
            growth = 1;
        }

        else if (TriggerButton.check == 2)
        {
            growth = 2;
        }

    }
}
