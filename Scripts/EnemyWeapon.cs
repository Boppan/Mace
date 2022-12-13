using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    
    public Transform firePoint;
    public GameObject bulletPrefab;

    private float timeBtwShots;
    public float startTimeBtwShots; 

    // Start is called before the first frame update
    void Start()
    {
        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwShots <= 0)
        {
            Shoot();
            timeBtwShots = startTimeBtwShots; 
        } else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
    void Shoot()
    {
        FindObjectOfType<AudioManager>().Play("EnemyFire");
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
