using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    [SerializeField] public float maxSpeed = 10f;

    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 700f;

    void FixedUpdate()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        float move = 0.7f;

        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

    }

    void Update()
    {

        if (grounded && Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));

        }

		if (this.gameObject != true)
		{
			Application.LoadLevel(0);
		}


    }
}
