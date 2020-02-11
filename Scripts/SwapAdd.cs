using UnityEngine;
using System.Collections;

public class SwapAdd : MonoBehaviour {

    public static int check;
    public GameObject white;
    public GameObject black;
    public GameObject des;
    public GameObject point;
    public GameObject swapAdd;
    Vector2 destination;
    Vector2 pointer;

    // Use this for initialization
    void Start () {

        check = 0;
        destination = des.transform.position;
        pointer = point.transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        Debug.Log(check + "Black");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        check = 1;

        if (check + Swap.check == 2)
        {

            if (col.gameObject.name == "White")
            {
                white.transform.position = destination;
                black.transform.position = pointer;
            }

            if (col.gameObject.name == "Black")
            {
                white.transform.position = pointer;
                black.transform.position = destination;
            }

            Destroy(swapAdd);
            Destroy(gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        check = 1;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        check = 0;
    }
}
