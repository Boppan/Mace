using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiMove : MonoBehaviour
{
    public float speed = 7f;
    public float movementDirection = 1f; 
    Rigidbody2D rb;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 newPosition = gameObject.transform.position;
        newPosition.x += speed * (Time.fixedDeltaTime) * movementDirection;
        rb.MovePosition(newPosition);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
