using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroy : MonoBehaviour
{
    public float interval;
    public GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
        
        Destroy(gameObject, interval);
        Instantiate(impactEffect, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
