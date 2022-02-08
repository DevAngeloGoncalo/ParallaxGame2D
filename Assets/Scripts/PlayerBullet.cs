using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    public float speed = 7F;
    public int bulletPower = 100;
    public Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();

        Physics2D.IgnoreLayerCollision(6, 6);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        rig.velocity = transform.right * speed;
    }

    //Destroy the object when collide
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);

        if (other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().DamageEnemy(bulletPower);
        }
    }
}
