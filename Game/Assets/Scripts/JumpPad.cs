using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    private Rigidbody2D rb;

    public float lauchForce = 20f;

    // Start is called before the first frame update
    void Start()
    {
        //Gets players rigidbody2d
        rb = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Lauches player
        rb.AddForce(new Vector2(rb.velocity.x, lauchForce), ForceMode2D.Impulse);
    }
}
