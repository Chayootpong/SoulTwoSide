using UnityEngine;
using System.Collections;

public class EnterTutorial : MonoBehaviour {

    public GameObject shade;
    public GameObject popup;
    public GameObject anim;
    public GameObject btn;
    public GameObject white;
    public GameObject black;
    public GameObject portal;

    float check = 0;

    // Use this for initialization
    void Start () {

        white.GetComponent<MovementWhite>().enabled = false;
        black.GetComponent<MovementBlack>().enabled = false;
        portal.GetComponent<Condition>().enabled = false;
        shade.SetActive(false);
        popup.SetActive(false);
        anim.SetActive(false);
        btn.SetActive(false);
        StartCoroutine("Popup");

    }
	
	// Update is called once per frame
	void Update () {

        if (check == 1)
        {

            if (Input.GetButtonDown("Red_P1"))
            {
                shade.SetActive(false);
                popup.SetActive(false);
                anim.SetActive(false);
                btn.SetActive(false);
                white.GetComponent<MovementWhite>().enabled = true;
                black.GetComponent<MovementBlack>().enabled = true;
                portal.GetComponent<Condition>().enabled = true;
                               
            }

        }
	
	}

    IEnumerator Popup() {

        yield return new WaitForSeconds(1);
        shade.SetActive(true);
        popup.SetActive(true);
        anim.SetActive(true);
        btn.SetActive(true);
        check = 1;


    }
}
