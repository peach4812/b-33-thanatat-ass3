using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadpool : SuperHero
{
    public void SpecialMove()
    {
        Debug.Log($"used Golden desert eagle");
    }
    public void Sword()
    {
        Debug.Log($" used samuria slash");

    }
    public void kickballs()
    {
        Debug.Log($" used kick balls");

    }
    //Ta tee law law
    public override void Move()
    {
        SpecialMove();
    }
    public override void Attack()
    {
        Sword();
    }
    public override void Start()
    {
        base.Start();
        Move();
        Attack();
        Sword();
    }
}
