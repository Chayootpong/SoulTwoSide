using UnityEngine;
using System.Collections;

public class CrushSwap : MonoBehaviour {

    public GameObject Crush;
    public GameObject terrain;
    public GameObject spike;
    int check = 0;
    int checks = 0;

    // Use this for initialization
    void Start () {

        terrain.SetActive(false);
        spike.SetActive(true);

    }
	
	// Update is called once per frame
	void Update () {

        if (checks == 1)
        {
            terrain.SetActive(true);
            spike.SetActive(false);
        }

        else if (checks == 0)
        {
            terrain.SetActive(false);
            spike.SetActive(true);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (check == 1)
        {

            checks = 0;
            Crush.transform.localScale = new Vector3(1, 1, 1);

        }

        else if (check == 0)
        {

            checks = 1;
            Crush.transform.localScale = new Vector3(1, -1, 1);

        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (checks == 1)
        {

            check = 1;
        }

        else if (checks == 0)
        {

            check = 0;
        }
    }
}
