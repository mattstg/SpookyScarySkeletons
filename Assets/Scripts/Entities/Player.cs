using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    

    GameObject orbPrefab;

    public override void Initialize()
    {
        base.Initialize();
        orbPrefab = Resources.Load<GameObject>("Prefabs/Orb");
    }
    public override void PhysicsRefresh()
    {
        base.PhysicsRefresh();
        Vector2 inputDir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));  //!Normalized
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Potion orb = GameObject.Instantiate(orbPrefab).GetComponent<Potion>();
            orb.gameObject.transform.position = transform.position;
            StartCoroutine(orb.UpdateThrowPosition(inputDir));
        }
        Move(inputDir);
    }

    public void Die()
    {
        Debug.Log("You lose");
    }
}
