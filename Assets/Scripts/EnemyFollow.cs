using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float startChaseDistance;

    private Transform target;


    public float attackRange;
    public int damage;
    private float lastAttackTime;
    public float attackDelay;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }



    // Update is called once per frame
    void Update()
    {


        if (Vector2.Distance(transform.position, target.position) > stoppingDistance && Vector2.Distance(transform.position, target.position) < startChaseDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }


        float distanceToPlayer = Vector3.Distance(transform.position, target.position);

        if (distanceToPlayer < attackRange)
        {
            if (Time.time > lastAttackTime + attackDelay)
            {
            target.SendMessage("Damage", damage);
            lastAttackTime = Time.time;

            }
        }



    }
}
