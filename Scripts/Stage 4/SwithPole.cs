using UnityEngine;
using System.Collections;

public class SwithPole : MonoBehaviour
{

    public GameObject Pole;
    public static int check;

    Vector2 positionA = new Vector2(0.8f, -0.8f);
    Vector2 positionB = new Vector2(14f, 2.5f);

    // Use this for initialization
    void Start()
    {
        check = 0;
        Pole.transform.position = positionA;
    }

    // Update is called once per frame
    void Update()
    {
        if (check == 1)
        {
            Pole.transform.position = Vector3.Lerp(Pole.transform.position, positionB, Time.deltaTime * 3);
        }

        else if (check == 2)
        {
            Pole.transform.position = Vector3.Lerp(Pole.transform.position, positionA, Time.deltaTime * 3);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        check = 1;
        //Pole.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D col)
    {
        check = 1;
        //Pole.SetActive(false);
        //Pole.transform.position = Vector3.Lerp(Pole.transform.position, positionB, Time.deltaTime * 5);
    }

    void OnTriggerExit2D(Collider2D col)
    {

        check = 2;
        //Pole.SetActive(true);
    }
}
