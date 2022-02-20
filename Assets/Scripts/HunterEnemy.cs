using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class HunterEnemy : Enemy
{
    protected override void Shoot()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        InitializeEnemy(10, 100, 3);
        Debug.Log(gameObject.name + " : " + Health + " : " + Ammo + " : " + Speed);
    }

    // Update is called once per frame
    void Update()
    {
        //ABSTRACTION
        Move();
    }
}
