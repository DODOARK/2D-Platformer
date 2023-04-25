using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SwitchMP : MonoBehaviour
{
    private SpriteRenderer sr;
    public GameObject target;
    private MovingPlatform MP;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        MP = target.GetComponent<MovingPlatform>();
        if (MP.active == true)
        {
            sr.color = Color.green;
        }
        else
        {
            sr.color = Color.red;
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
            MP.active = true;
        }
        else if (collision.name == "Player")
        {
            sr.color = Color.red;
            MP.active = false;
        }
    }
}
