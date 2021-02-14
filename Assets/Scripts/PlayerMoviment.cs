using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public float speed = 0f;
    public float shotDistance = 3f;

    public Rigidbody2D rb;
    public Animator anim;
    public GameObject shot;

    Vector2 moviment;
    Vector2 mousePos;

    // Fixed Update is called once per frame
    void FixedUpdate()
    {
        moviment.x = Input.GetAxisRaw("Horizontal");
        moviment.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", moviment.x);
        anim.SetFloat("Vertical", moviment.y);
        anim.SetFloat("Speed", moviment.magnitude);

        rb.MovePosition(rb.position + moviment.normalized * speed * Time.fixedDeltaTime);

        if (Input.GetButtonDown("Fire1")) {
            anim.SetTrigger("Shot");
        }

        if(moviment != Vector2.zero)
        {
            anim.SetFloat("Idle_Horizontal", moviment.x);
            anim.SetFloat("Idle_Vertical", moviment.y);
        }
     }
}
