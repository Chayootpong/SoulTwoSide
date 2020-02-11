using UnityEngine;
using System.Collections;

public class HideAndSeek : MonoBehaviour {

    float distancelight;
    float distancedark;
    public Transform lights;
    public Transform darks;
    public GameObject spike;

	// Use this for initialization
	void Start () {

        spike.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        //Debug.Log(distancelight);

        distancelight = Vector2.Distance(lights.position, transform.position);
        distancedark = Vector2.Distance(darks.position, transform.position);

        if (distancelight < 1 || distancedark < 1)
        {
            spike.SetActive(true);
        }

        else if (distancelight <= 3)
        {
            spike.SetActive(true);
        }

        else
        {
            spike.SetActive(false);
        }

        

    }
}
