using UnityEngine;
using System.Collections;

public class CrushPoleS8 : MonoBehaviour {

    public GameObject Crush;
    public GameObject Pole;
    int check = 0;
    int checks = 0;

    Vector2 positionA = new Vector2(11, 3.2f);
    Vector2 positionB = new Vector2(15, 6);

    // Use this for initialization

    void Start () {

        Pole.transform.position = positionA;

    }
	
	// Update is called once per frame
	void Update () {

        if (checks == 1)
        {
            Pole.transform.position = Vector3.Lerp(Pole.transform.position, positionB, Time.deltaTime * 5);
        }

        else if (checks == 0)
        {
            Pole.transform.position = Vector3.Lerp(Pole.transform.position, positionA, Time.deltaTime * 5);
        }

    }

    void OnTriggerEnter2D(Collider2D col) {

        if (check == 1){

            checks = 0;
            Crush.transform.localScale = new Vector3(1, 1, 1);

        }

        else if (check == 0){

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
