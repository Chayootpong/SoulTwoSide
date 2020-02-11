using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class Condition : MonoBehaviour {

    public GameObject Lose;
    public GameObject Win;
    public GameObject RestartLose;
    public GameObject MenuLose;
    public GameObject RestartWin;
    public GameObject MenuWin;
    public GameObject Continues;
    public GameObject Black;
    public GameObject White;
    public GameObject Shade;
    public GameObject Pause;
    public GameObject Resume;
    public GameObject RestartPause;
    public GameObject MenuPause;

    public GameObject bgSound;
    float audioVolume;
    AudioSource audiowin;
    AudioSource audiolose;

    float distancewhite;
    float distanceblack;
    public static int checkpause;
    public static int checkwin;
    bool hasPlayWin;
    bool hasPlayLose;

    public Transform white;
    public Transform black;

    // Use this for initialization
    void Start () {

        Lose.SetActive(false);
        MenuLose.SetActive(false);
        RestartLose.SetActive(false);
        Win.SetActive(false);
        MenuWin.SetActive(false);
        RestartWin.SetActive(false);
        Continues.SetActive(false);
        Pause.SetActive(false);
        MenuPause.SetActive(false);
        RestartPause.SetActive(false);
        Resume.SetActive(false);
        Shade.SetActive(false);
        checkwin = 0;

        AudioSource[] audios = GetComponents<AudioSource>();
        audiowin = audios[0];
        audiolose = audios[1];
        bgSound.GetComponent<AudioSource>().mute = false;
        audioVolume = 1;
        hasPlayLose = false;
        hasPlayWin = false;

    }
	
	// Update is called once per frame
	void Update () {

        if (MovementWhite.death == true || GameObject.Find("Black") == null) {

            StartCoroutine("DelaytimeLose");
            StartCoroutine("FadeOut");
        }

        distancewhite = Vector2.Distance(white.position, transform.position);
        distanceblack = Vector2.Distance(black.position, transform.position);

        if (distancewhite <= 1.5f && distanceblack <= 1.5f)
        {
            StartCoroutine("DelaytimeWin");
            StartCoroutine("FadeOut");
        }

        if (Input.GetButtonDown("Blue_P1"))
        {
            if (checkpause == 0 && checkwin != 1) {

                Pausing();
            }

            else if (checkpause == 1)
            {

                Unpausing();
            }
        }

        if (Input.GetButtonDown("Blue_P2"))
        {
            if (checkpause == 0 && checkwin != 1)
            {

                Pausing();
            }

            else if (checkpause == 1)
            {

                Unpausing();
            }
        }

    }

    IEnumerator DelaytimeLose()
    {

        if (MovementWhite.death == true)
        {
            Black.GetComponent<MovementBlack>().enabled = false;
            Black.GetComponent<Rigidbody2D>().isKinematic = true;
            White.GetComponent<MovementWhite>().enabled = false;
            White.GetComponent<Rigidbody2D>().isKinematic = true;
        }

        else if (MovementWhite.death == true)
        {
            Black.GetComponent<MovementBlack>().enabled = false;
            Black.GetComponent<Rigidbody2D>().isKinematic = true;
            White.GetComponent<MovementWhite>().enabled = false;
            White.GetComponent<Rigidbody2D>().isKinematic = true;
        }

        yield return new WaitForSeconds(1);
        Shade.SetActive(true);
        Lose.SetActive(true);

        if (!hasPlayLose)
        {
            audiolose.Play();
            hasPlayLose = true;
        }
        
        yield return new WaitForSeconds(1.5f);
        MenuLose.SetActive(true);
        RestartLose.SetActive(true);
        GetComponent<Control>().enabled = true;

    }

    IEnumerator DelaytimeWin()
    {

        checkwin = 1;
        Black.GetComponent<MovementBlack>().enabled = false;
        White.GetComponent<MovementWhite>().enabled = false;
        Black.GetComponent<Rigidbody2D>().isKinematic = true;
        White.GetComponent<Rigidbody2D>().isKinematic = true;
        Shade.SetActive(true);
        yield return new WaitForSeconds(1);
        Win.SetActive(true);

        if (!hasPlayWin)
        {
            audiowin.Play();
            hasPlayWin = true;
        }
        
        yield return new WaitForSeconds(1.5f);
        MenuWin.SetActive(true);
        RestartWin.SetActive(true);
        Continues.SetActive(true);
        GetComponent<Control>().enabled = true;

    }

    void Pausing() {

        bgSound.GetComponent<AudioSource>().mute = true;

        checkpause = 1;
        Shade.SetActive(true);
        Black.GetComponent<MovementBlack>().enabled = false;
        White.GetComponent<MovementWhite>().enabled = false;
        Black.GetComponent<Rigidbody2D>().isKinematic = true;
        White.GetComponent<Rigidbody2D>().isKinematic = true;
        GetComponent<Control>().enabled = true;
        Pause.SetActive(true);
        Resume.SetActive(true);
        RestartPause.SetActive(true);
        MenuPause.SetActive(true);
    }

    void Unpausing()
    {
        bgSound.GetComponent<AudioSource>().mute = false;

        checkpause = 0;
        Shade.SetActive(false);
        Black.GetComponent<MovementBlack>().enabled = true;
        White.GetComponent<MovementWhite>().enabled = true;
        Black.GetComponent<Rigidbody2D>().isKinematic = false;
        White.GetComponent<Rigidbody2D>().isKinematic = false;
        GetComponent<Control>().enabled = false;
        Pause.SetActive(false);
        Resume.SetActive(false);
        RestartPause.SetActive(false);
        MenuPause.SetActive(false);

    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(1 / 4);
        bgSound.GetComponent<AudioSource>().volume = 0.6f;
        yield return new WaitForSeconds(1 / 2);
        bgSound.GetComponent<AudioSource>().volume = 0.4f;
        yield return new WaitForSeconds(3 / 4);
        bgSound.GetComponent<AudioSource>().volume = 0.2f;
        yield return new WaitForSeconds(1);
        bgSound.GetComponent<AudioSource>().mute = true;
    }
}
