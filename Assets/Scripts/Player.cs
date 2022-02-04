using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anim;

    private float shotCounter;
    private bool canFire;

    public float speed, jumpForce, timeBetweenShoots;
    public bool isJumping;

    public GameObject bulletFire;
    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        Shoot();
    }

    void Move()
    {
        Vector3 movemant = new Vector3(Input.GetAxis("Horizontal"), 0F, 0F);
        transform.position += movemant * Time.deltaTime * speed;

        if (Input.GetAxis("Horizontal") > 0F)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector3(0F, 0F, 0F);

        }

        if (Input.GetAxis("Horizontal") < 0F)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector3(0F, 180F, 0F); //Rotacionar caso esteja olhando para esquerda AG20220203

        }

        if (Input.GetAxis("Horizontal") == 0F)
        {
            anim.SetBool("run", false);
        }

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!isJumping)
            {
                rig.AddForce(new Vector2(0F, jumpForce), ForceMode2D.Impulse);
                anim.SetBool("jump", true);
            }
        }
    }

    void Shoot()
    {

        if (Time.time - shotCounter > timeBetweenShoots)
        {
            canFire = true;
        }

        //Clicar e Atirar --- Mouse1 = 0, Scroll = 1, mouse2 = 2;
        if (Input.GetMouseButtonDown(0))
        {
            if (canFire == true)
            {  
                Instantiate(bulletFire, firePoint.position, firePoint.rotation);
                shotCounter = Time.time;
                canFire = false;
            }
        }

        //Atirar e segurar
        if (Input.GetMouseButton(0))
        {
            //Contador de Disparos por frame
            if (canFire == true)
            {
                
                Instantiate(bulletFire, firePoint.position, firePoint.rotation);
                
                shotCounter = Time.time;
                canFire = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isJumping = false;
            anim.SetBool("jump", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isJumping = true;
        }

    }
}
