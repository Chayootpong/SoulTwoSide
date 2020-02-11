using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class MovementWhite : MonoBehaviour {

    public AudioClip jump;
    AudioSource audioj;

    public float speed = 50f;
    public float maxSpeed = 3f;
    float jumpPower = 370f;

    public bool grounded;
    public static bool death;

    private Rigidbody2D rb2d;
    private Animator anim;

    private bool icepath;

    Vector3 easeVelocity;


    // Use this for initialization
    void Start () {

        death = false;
        icepath = false;
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        audioj = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("Death", death);

        if (Input.GetAxis("Horizontal_P1") < -0.1f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetAxis("Horizontal_P1") > 0.1f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetButtonDown("Jump_P1") && grounded)
        {
            rb2d.AddForce(Vector2.up * jumpPower);
            audioj.PlayOneShot(jump, 0.7F);
        }

        
    }

    void FixedUpdate() {

        easeVelocity = rb2d.velocity;
        easeVelocity.y = rb2d.velocity.y;
        easeVelocity.z = 0.0f;

        if (icepath == true)
        {
            //easeVelocity.x *= 2f;
            maxSpeed = 5f;
            speed = 5;
            
        }

        else if (icepath == false)
        {
            maxSpeed = 3f;
            easeVelocity.x *= 0.75f;
            speed = 50;           
        }


        float h = Input.GetAxis("Horizontal_P1");

        if (grounded) {

            rb2d.velocity = easeVelocity;
        }

        rb2d.AddForce((Vector2.right * speed) * h);

        if (rb2d.velocity.x > maxSpeed) {

            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);

        }

        if (rb2d.velocity.x < -maxSpeed)
        {

            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);

        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Spikes")
        {
            StartCoroutine("Death");
        }    
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Icepath")
        {
            icepath = true;
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.name == "Icepath")
        {
            icepath = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name == "Icepath")
        {
            icepath = false;
        }
    }

    IEnumerator Death()
    {
        death = true;

        GetComponent<Rigidbody2D>().isKinematic = true;

        yield return new WaitForSeconds(1);

        Destroy(gameObject);
    }
}
