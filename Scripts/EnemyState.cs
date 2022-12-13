using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect;

    public bool isRobot;
    public bool isRat; 
    public bool isDoorman;
    public bool isOldLady;
    
    public void TakeDamage (int damage)
    {
        
        if (isDoorman)
        {
            FindObjectOfType<AudioManager>().Play("DoorManDmg");
        }
        else if (isRat)
        {
            FindObjectOfType<AudioManager>().Play("RatDmg");
        }
        else if (isRobot)
        {
            FindObjectOfType<AudioManager>().Play("RobotDmg");
        }
        else if (isOldLady)
        {
            FindObjectOfType<AudioManager>().Play("OldLadyDmg");
        }

        health -= damage;

        if(health <= 0)
        {

            if (isDoorman)
            {
                FindObjectOfType<AudioManager>().Play("DoorManDeath");
            }
            else if (isRat)
            {
                FindObjectOfType<AudioManager>().Play("RatDeath");
            }
            else if (isOldLady)
            {
                FindObjectOfType<AudioManager>().Play("OldLadyDeath");
            }
            Die();
        }
    }
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        
        Destroy(gameObject);
    }
}
