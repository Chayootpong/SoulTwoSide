﻿using UnityEngine;
using System.Collections;

public class RiftSP2 : MonoBehaviour {

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
        anim.SetInteger("Check", TriggerButton2.check);

        if (TriggerButton2.check == 1)
        {
            growth = 1;
        }

        else if (TriggerButton2.check == 2)
        {
            growth = 2;
        }

    }
}
