using UnityEngine;
using System.Collections;

public class SelectStage : MonoBehaviour {

    public GameObject unlock2;
    public GameObject unlock3;
    public GameObject unlock4;
    public GameObject unlock5;
    public GameObject others;

    // Use this for initialization
    void Start () {

        unlock2.SetActive(true);
        unlock3.SetActive(true);
        unlock4.SetActive(true);
        unlock5.SetActive(true);

    }
	
	// Update is called once per frame
	void Update () {

        Unlock();

        if (Input.GetButtonDown("Yellow_P1"))
        {

            if (GameObject.Find("Glow_1") != null)
            {

                Application.LoadLevel("Stage I");
            }

            if (GameObject.Find("Glow_2") != null && GameObject.Find("Locker2") == null)
            {

                Application.LoadLevel("Stage II");
            }

            if (GameObject.Find("Glow_3") != null && GameObject.Find("Locker3") == null)
            {

                Application.LoadLevel("Stage III");
            }

            if (GameObject.Find("Glow_4") != null && GameObject.Find("Locker4") == null)
            {

                Application.LoadLevel("Stage IV");
            }

            if (GameObject.Find("Glow_5") != null && GameObject.Find("Locker5") == null)
            {

                Application.LoadLevel("Stage V");
            }

            if (GameObject.Find("Glow_6") != null && GameObject.Find("Locker6") == null)
            {

                Application.LoadLevel("Stage VI");
            }

            if (GameObject.Find("Glow_7") != null && GameObject.Find("Locker7") == null)
            {

                Application.LoadLevel("Stage VII");
            }

            if (GameObject.Find("Glow_8") != null && GameObject.Find("Locker8") == null)
            {

                Application.LoadLevel("Stage VIII");
            }

            if (GameObject.Find("Glow_9") != null && GameObject.Find("Locker9") == null)
            {

                Application.LoadLevel("Stage IX");
            }

            if (GameObject.Find("Glow_10") != null && GameObject.Find("Locker10") == null)
            {

                Application.LoadLevel("Stage X");
            }

            if (GameObject.Find("Glow_11") != null && GameObject.Find("Locker11") == null)
            {

                Application.LoadLevel("Stage XI");
            }

            if (GameObject.Find("Glow_12") != null && GameObject.Find("Locker12") == null)
            {

                Application.LoadLevel("Stage XII");
            }

            //if...
        }

        if (Input.GetButtonDown("Red_P1")){

            Application.LoadLevel("Menu");
        }

        if (Input.GetButtonDown("Cheater"))
        {

            unlock2.SetActive(false);
            unlock3.SetActive(false);
            unlock4.SetActive(false);
            unlock5.SetActive(false);
            others.SetActive(false);

        }


    }

    void Unlock() {

        if (StageI.winone == 1) {

            unlock2.SetActive(false);
        }

        if (StageII.wintwo == 1)
        {

            unlock3.SetActive(false);
        }

        if (StageIII.winthree == 1)
        {

            unlock4.SetActive(false);
        }

        if (StageIV.winfour == 1)
        {

            unlock5.SetActive(false);
        }
    }
}
