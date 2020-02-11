using UnityEngine;
using System.Collections;

public class Crush111 : MonoBehaviour {

    public GameObject crush;
    public GameObject lift1;
    int check = 0;
    public static int checks;

    Vector3 positionA = new Vector3(4f, -4.5f);
    Vector3 positionB = new Vector3(3.1f, -9f);

    // Use this for initialization
    void Start () {

        checks = 0;
        lift1.transform.position = positionA;

    }
	
	// Update is called once per frame
	void Update () {

        if (checks == 1)
        {
            lift1.transform.position = Vector3.Lerp(lift1.transform.position, positionB, Time.deltaTime * 5);
        }

        else if (checks == 0)
        {
            lift1.transform.position = Vector3.Lerp(lift1.transform.position, positionA, Time.deltaTime * 5);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (check == 1)
        {

            checks = 0;
            crush.transform.localScale = new Vector3(1, 1, 1);

        }

        else if (check == 0)
        {

            checks = 1;
            crush.transform.localScale = new Vector3(1, -1, 1);

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
