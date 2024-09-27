using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SuperHero : MonoBehaviour
{
    //Attributes
    protected string name;
    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }
    protected int hp;
    public int Hp
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
        }
    }
    protected string suitColor;
    public string SuitColor
    {
        get
        {
            return suitColor;
        }
        set
        {
            suitColor = value;
        }
    }
    protected float armorStrength;
    public void UpdateArmor(float strength)
    {
        armorStrength += strength;
        Debug.Log($"{Name} undateed their armor to {armorStrength}");
    }
    public void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log($"{Name} take {damage} damage hp: {hp}");
    }
    public bool IsDead()
    {
        return hp <= 0;
    }

    //Abstract
    public abstract void Move();
    public abstract void Attack();

    //start
    public virtual void Start()
    {
        Debug.Log("***Abstract Class SuperHero***");
    }
}
