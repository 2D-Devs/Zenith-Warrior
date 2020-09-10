using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f; // Follow speed

    public bool hasTarget = false; // do I have a target to move towards?
    public GameObject target; // the target I want to get closer to

    private Rigidbody2D rb;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasTarget)
        {
            // get distance between me and my target
            float distance = Vector3.Distance(transform.position, target.transform.position);
            // if I am further than 2 units away
            if (distance > 2)
            {
                follow(target.transform); // do a follow
            }
        }
    }

    // if anything starts to collide with me I will run this method
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("PlayerObject")) // is the other object the player?
        {
            target = collision.gameObject; // it is so set him as my target

            hasTarget = true; // I have an object
        }
    }

    // if something is no longer colliding with me I will run this code
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name.Equals("PlayerObject"))
        {
            target = null;
            hasTarget = false;
        }
    }

    private void follow(Transform target)
    {
        // add force to my rigid body to make me move
        rb.AddForce((target.transform.position - transform.position).normalized * speed);
    }
}
