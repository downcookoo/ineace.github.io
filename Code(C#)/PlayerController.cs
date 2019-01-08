using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;
    public Transform groundCheck;
    public float groundCheckradius;
    public LayerMask whatIsGround;
    private bool grounded;
    private float moveVelocity;
    public float speed;

    public AudioSource jumpSound;

    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRight;

    public int Ammo;

    private Animator Anim;

    public Transform firePoint;
    public GameObject bullet;

	// Use this for initialization
	void Start () {
        Anim = GetComponent<Animator>();
        
	}

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckradius, whatIsGround);
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            jumpSound.Play();
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }

        moveVelocity = 0f;

        if (Input.GetKey(KeyCode.D))
        {
            
            //GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = moveSpeed;
            

        }


        if (Input.GetKey(KeyCode.A))
        {
            
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = -moveSpeed;
            
        }


        if (knockbackCount <= 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
        } else
        {
            if (knockFromRight)
                GetComponent<Rigidbody2D>().velocity = new Vector2(-knockback, knockback);
            if (!knockFromRight)
                GetComponent<Rigidbody2D>().velocity = new Vector2(knockback, knockback);
            knockbackCount -= Time.deltaTime;
        }

        Anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(1f, 1f, 1f);
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
            transform.localScale = new Vector3(-1f, 1f, 1f);

        if (Input.GetKeyDown(KeyCode.Return) && Ammo > 0)
        {
            Ammo = Ammo - 1;
            Instantiate(bullet, firePoint.position, firePoint.rotation);

        }
        if (Input.GetKeyDown(KeyCode.R) && Ammo == 0)
        {
            Ammo = 3;
        }

    }

    
}
