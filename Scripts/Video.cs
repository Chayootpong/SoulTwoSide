using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class Video : MonoBehaviour {

	public MovieTexture movTexture;
	private AudioSource audios;
    public float timeLeft = 0f;

    // Use this for initialization
    void Start () {

        //gogo = new myGoGolib();
        //gogo.setupComm(myGoGolib.typeCommu.useSerial, "COM3");
        GetComponent<RawImage> ().texture = movTexture as MovieTexture;
		audios = GetComponent<AudioSource>();
		audios.clip = movTexture.audioClip;
		movTexture.Play();
		audios.Play ();

    }
	
	// Update is called once per frame
	void Update () {

        timeLeft += Time.deltaTime;

        if ((int)timeLeft > 75) {

            audios.Stop();
            Application.LoadLevel("Start");

        }

        //gogo.readSensor(6);
        //gogo.serialCom_DataReceivedWithUnity();
        //print("Senser 6 :" + gogo.senVa);
        if (Input.GetButtonDown("Cheater")) {

            audios.Stop();
            Application.LoadLevel("Start");

        }

    }
}
