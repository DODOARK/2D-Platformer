using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityModifier : MonoBehaviour
{
    private Rigidbody2D rb;
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Modifies player rb to zero gravity
        rb.gravityScale = 0;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Modifies player rb to default settings
        rb.gravityScale = 2;
    }
}
