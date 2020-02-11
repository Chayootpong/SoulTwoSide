using UnityEngine;
using System.Collections;

public class StageControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Horizontal_P1") < -0.1f)
        {
            transform.Translate(Vector2.left * Time.deltaTime * 7);
        }

        if (Input.GetAxis("Horizontal_P1") > 0.1f)
        {
            transform.Translate(Vector2.right * Time.deltaTime * 7);
        }

        if (Input.GetAxis("Vertical_P1") < -0.1f)
        {
            transform.Translate(Vector2.down * Time.deltaTime * 7);
        }

        if (Input.GetAxis("Vertical_P1") > 0.1f)
        {
            transform.Translate(Vector2.up * Time.deltaTime * 7);
        }

    }
}
