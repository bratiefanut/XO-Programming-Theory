using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class ScoutEnemy : Enemy
{

    //POLYMORPHISM
    protected override void Shoot()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Awake()
    {
        InitializeEnemy(10, 100, 1);

        Debug.Log(gameObject.name+" : " + Health +" : "+ Ammo +" : "+ Speed);
    }

    // Update is called once per frame
    void Update()
    {

        Move();
    }
}
