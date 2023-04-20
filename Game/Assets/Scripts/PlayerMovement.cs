using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject cam;

    private bool grounded;

    public float jumpHeight = 1f;
    public float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //Gets players rigidbody2d
        rb = GetComponent<Rigidbody2D>();

        //Gets gameobject called main camera
        cam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //Ground Test
        if (rb.velocity.y == 0f) { grounded = true; }else { grounded = false; }

        //Move camera to player
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, -10);

        //Jumping
        if (Input.GetKey("w") && grounded && rb.gravityScale == 1) { rb.AddForce(new Vector2(rb.velocity.x, jumpHeight), ForceMode2D.Impulse); }

        //Zero gravity up/down movement
        if (Input.GetKey("w") && rb.gravityScale == 0) { rb.velocity = new Vector2(rb.velocity.x, moveSpeed); }
        if (Input.GetKey("s") && rb.gravityScale == 0) { rb.velocity = new Vector2(rb.velocity.x, -moveSpeed); }
    }

    void FixedUpdate()
    {
        //Sideways movement
        if (Input.GetKey("a")) { rb.velocity = new Vector2(-moveSpeed, rb.velocity.y); }
        if (Input.GetKey("d")) { rb.velocity = new Vector2(moveSpeed, rb.velocity.y); }
    }
}
