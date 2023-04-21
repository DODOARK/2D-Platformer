using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject movingPlat;
    public GameObject spot1;
    public GameObject spot2;
    private GameObject nextTarget;

    public float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        movingPlat.transform.position = spot1.transform.position;
        nextTarget = spot2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (movingPlat.transform.position == spot1.transform.position)
        {
            nextTarget = spot2;
        }
        else if (movingPlat.transform.position == spot2.transform.position)
        {
            nextTarget = spot1;
        }
        UpdatePosition();
    }

    void UpdatePosition()
    {
        movingPlat.transform.position = Vector3.MoveTowards(movingPlat.transform.position, nextTarget.transform.position, moveSpeed);
    }
}
