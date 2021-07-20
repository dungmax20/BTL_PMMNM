using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public Rigidbody2D rigid;
    [SerializeField] public float force = 200f;
    [SerializeField] public float speed = 3f;
    public bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Jump();
            }

            Movement();
        }

    }
    private void Movement()
    {
        var vel = rigid.velocity;
        vel.x = speed;
        rigid.velocity = vel;
    }

    private void Jump()
    {
        rigid.velocity = Vector2.zero;
        rigid.AddForce(Vector2.up * force);
    }
}
