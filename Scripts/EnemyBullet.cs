using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;
    public int damage = 2;
    public GameObject impactEffect;

    //private Transform player;
    private Transform targetPoint;
    private Vector2 target;


    // Start is called before the first frame update
    void Start()
    {
        targetPoint = GameObject.FindGameObjectWithTag("TargetPoint").transform;

        target = new Vector2(targetPoint.position.x, targetPoint.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerState playerState = hitInfo.GetComponent<PlayerState>();
        if (playerState != null)
        {
            playerState.DoHarm(damage);
        }
        
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
