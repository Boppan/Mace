using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    public Weapon weapon; 

    // Start is called before the first frame update
    void Start()
    {

        weapon.enabled = false;

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        weapon.enabled = true;
        FindObjectOfType<AudioManager>().Play("PickUpWeapon");
        Destroy(gameObject);
    }
}
