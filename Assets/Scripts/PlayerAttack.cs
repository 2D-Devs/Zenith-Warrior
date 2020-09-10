using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator anim;
    public float attackTime;
    public float startTimeAttack;

    public Transform attackLocation;
    public float attackRange;
    public LayerMask enemies;

    private SFXManager sfxMan;

    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
        sfxMan = FindObjectOfType<SFXManager>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (attackTime <= 0)
        {
            if (Input.GetButton("Fire1"))
            {
                anim.SetBool("Is_Attacking", true);
                Collider2D[] damage = Physics2D.OverlapCircleAll(attackLocation.position, attackRange, enemies);

                sfxMan.heroAttack.Play();

                for (int i = 0; i < damage.Length; i++)
                {
                    Destroy(damage[i].gameObject);
                }
            }
            attackTime = startTimeAttack;
        }
        else
        {
            attackTime -= Time.deltaTime;
            anim.SetBool("Is_Attacking", false);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackLocation.position, attackRange);
    }
}