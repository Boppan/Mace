
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : MonoBehaviour
{
    [SerializeField] private ParticleSystem particles;
    [SerializeField] private SpriteRenderer sprietRenderer;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip pickupClip;


    public Transform nextBeer;
    public GameObject beer;

    private bool canPickupCoin = true;

    private bool removeGameObject;
    private float timer;
    
    [SerializeField] private float timeBeforeDeletion = 1f;
    

    private void Update(){
        if(removeGameObject == true) {
            timer += Time.deltaTime;
            if(timer > timeBeforeDeletion) {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Player") == true) {
            if (canPickupCoin == true) {
                collision.GetComponent<PlayerState>().CoinPickup();
                sprietRenderer.sprite = null;
                animator.enabled = false;
                particles.Play();
                removeGameObject = true;
                canPickupCoin = false;
                audioSource.pitch = Random.Range(0.9f, 1.1f);
                audioSource.PlayOneShot(pickupClip);
                Instantiate(beer, nextBeer.position, nextBeer.rotation);
            }
            

        }
       
    }
    

}
