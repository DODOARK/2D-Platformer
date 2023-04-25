using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRP : MonoBehaviour
{
    private SpriteRenderer sr;
    public GameObject target;
    private RotatingPlatform RP;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        RP = target.GetComponent<RotatingPlatform>();
        if (RP.active == true)
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
            RP.active = true;
        }
        else if (collision.name == "Player")
        {
            sr.color = Color.red;
            RP.active = false;
        }
    }
}
