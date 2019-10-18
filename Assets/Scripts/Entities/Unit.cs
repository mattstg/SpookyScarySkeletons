using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;
    public virtual void Initialize()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public virtual void Move(Vector2 inputDir)
    {
        //animation
        rb.velocity = inputDir.normalized * moveSpeed;
    }

    public virtual void PostInitialize()
    {

    }

    public virtual void Refresh()
    {

    }

    public virtual void PhysicsRefresh()
    {
       
    }

}
