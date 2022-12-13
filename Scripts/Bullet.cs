using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb; 
    public int damage = 40;
    public GameObject impactEffect;
   

    void Start()
    {
        rb.velocity = transform.right * speed; 
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyState enemy = hitInfo.GetComponent<EnemyState>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
