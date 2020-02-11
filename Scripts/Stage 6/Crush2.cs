using UnityEngine;
using System.Collections;

public class Crush2 : MonoBehaviour {

    public GameObject crush;
    public GameObject lift1;
    public GameObject lift2;
    int check = 0;
    public static int checks;

    Vector3 positionA = new Vector3(5.91f, 3.23f);
    Vector3 positionB = new Vector3(5.91f, 1.05f);

    Vector3 positionC = new Vector3(1.07f, -1.3f,0);
    Vector3 positionD = new Vector3(1.07f, -4.1f,0);

    // Use this for initialization
    void Start () {

        checks = 0;
        lift1.transform.position = positionA;
        lift2.transform.position = positionC;

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

        if ((checks + Crush1.checks) % 2 == 0)
        {
            lift2.transform.position = Vector3.Lerp(lift2.transform.position, positionC, Time.deltaTime * 5);
        }

        else if ((checks + Crush1.checks) % 2 == 1)
        {
            lift2.transform.position = Vector3.Lerp(lift2.transform.position, positionD, Time.deltaTime * 5);
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
