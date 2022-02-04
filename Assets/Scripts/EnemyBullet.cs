using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 7F;
    private bool hit;
    public Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();

        Physics2D.IgnoreLayerCollision(10, 10);
        Physics2D.IgnoreLayerCollision(10, 9);
        Physics2D.IgnoreLayerCollision(10, 7);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (!hit)
        {
            rig.velocity = -transform.right * speed;
        }
        else
        {
            rig.velocity = Vector2.zero;
        }
        
    }

    //Destroy the object when collide
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        hit = true;

        if (other.tag == "Player")
        {
            other.GetComponent<Player>().KillPlayer(hit);
        }
    }
}
