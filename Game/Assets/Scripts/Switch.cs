using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    private SpriteRenderer sr;
    private Animator animator;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.red;
        if (target.GetComponent<Animator>() != null)
        {
            animator = target.GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (sr.color == Color.red && collision.name == "Player")
        {
            sr.color = Color.green;
            animator.SetBool("Open", true);
        }
        else if (collision.name == "Player")
        {
            sr.color = Color.red;
            animator.SetBool("Open", false);
        }
    }
}
