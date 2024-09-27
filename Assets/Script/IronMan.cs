using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMan : SuperHero
{
    //atribute
    public void Fly()
    {
        Debug.Log($"--------{Name} is Flying!!!");
    }

    //ta tee
    public void ShootLaser()
    {
        Debug.Log($"========{Name} is Shooting Lasers!");
    }

    public override void Move()
    {
        Fly();
    }

    public override void Attack()
    {
        ShootLaser();
    }

    //overdress
    public override void Start()
    {
        base.Start();
        Name = "Tony";
        Move();
        Attack();
    }
}
