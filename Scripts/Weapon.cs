using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            animator.SetTrigger("hasShot");
        }
    }
    void Shoot()
    {
        FindObjectOfType<AudioManager>().Play("PlayerFire");
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
    }
}
