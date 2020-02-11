using UnityEngine;
using System.Collections;

public class Hider : MonoBehaviour {

    float distancelight;
    public Transform lights;
    public GameObject floor;
    public GameObject pop;

    // Use this for initialization
    void Start () {

        floor.SetActive(false);
        pop.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        distancelight = Vector2.Distance(lights.position, transform.position);

        if (distancelight <= 3)
        {
            floor.SetActive(true);
            pop.SetActive(true);
        }

        else
        {
            floor.SetActive(false);
            pop.SetActive(false);
        }


    }
}
