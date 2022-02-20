using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    private int m_health;
    private int m_ammo;
    private int m_speed;

    //ENCAPSULATION
    protected int Health {
        get { return m_health; }
        private set { m_health = value; } 
    }
    protected int Ammo
    {
        get { return m_ammo; }
        private set { m_ammo = value; }
    }
    protected int Speed
    {
        get { return m_speed; }
        private set { m_speed = value; }
    }

    protected virtual void InitializeEnemy(int health, int ammo, int speed)
    {
        Health = health;
        Ammo = ammo;
        Speed = speed;
    }

    protected abstract void Shoot();

    protected virtual void Move()
    {
        transform.Translate(Vector2.down * m_speed * Time.deltaTime);
    }

    protected virtual void TakeDamage(int damage)
    {
        m_health -= damage;
    }

    protected virtual void IncreaseHealth(int health)
    {
        m_health += health;
    }
}
