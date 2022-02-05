using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    private Rigidbody2D rig;
    private Animator anim;
    private BoxCollider2D boxCollider;

    private bool bFlagDeath;

    public float speed = 7F, delay = 0F;
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();

        Physics2D.IgnoreLayerCollision(7, 3);
        Physics2D.IgnoreLayerCollision(7, 7);
        Physics2D.IgnoreLayerCollision(7, 9);
        Physics2D.IgnoreLayerCollision(7, 10);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        
        if (!bFlagDeath)
        {
            rig.velocity = -transform.right * speed;
        }
        else
        {
            rig.velocity = Vector3.zero;
        }
    }

    public void DamageEnemy(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            boxCollider.enabled = false;
            UIController.scorePoints += 1;
            bFlagDeath = true;
            anim.Play("death");
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
        }
    }
}
