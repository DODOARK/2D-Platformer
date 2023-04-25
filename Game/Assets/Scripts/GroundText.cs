using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundText : MonoBehaviour
{
    private GameObject player;
    private PlayerMovement playerC;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerC = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<SpriteRenderer>().sortingLayerName == "MovingPlatform" || collision.GetComponent<SpriteRenderer>().sortingLayerName == "Ground")
        {
            playerC.grounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<SpriteRenderer>().sortingLayerName == "MovingPlatform" || collision.GetComponent<SpriteRenderer>().sortingLayerName == "Ground")
        {
            playerC.grounded = false;
        }
    }
}
