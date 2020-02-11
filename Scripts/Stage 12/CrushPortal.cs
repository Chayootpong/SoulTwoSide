using UnityEngine;
using System.Collections;

public class CrushPortal : MonoBehaviour {

    // Use this for initialization
    public GameObject Crush;
    public GameObject portal;
    int check = 0;
    int checks = 0;

    void Start()
    {

        portal.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if (checks == 1)
        {
            portal.SetActive(true);
        }

        else if (checks == 0)
        {
            portal.SetActive(false);
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
