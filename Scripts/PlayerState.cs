using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{

    public int healthPoints = 2;
    public int initialHealthPoints = 2;

    public int coinAmount = 0;

    private GameObject respawnPosition;
    [SerializeField] private GameObject startPosition;

    [SerializeField] private bool useStartPosition = true;

    // Start is called before the first frame update
    void Start()
    {
        healthPoints = initialHealthPoints;
        if (useStartPosition == true) {
            gameObject.transform.position = startPosition.transform.position;
        }
        respawnPosition = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoHarm(int doHarmByThisMuch) {
        FindObjectOfType<AudioManager>().Play("PlayerHarmed");
        healthPoints -= doHarmByThisMuch;
        if(healthPoints <= 0) {
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            Respawn();
        }
    }

    public void Respawn( ) {
        healthPoints = initialHealthPoints;
        gameObject.transform.position = respawnPosition.transform.position;
    }

    public void CoinPickup() {
        coinAmount++;
        AddLife();
    }

    public void ChangeRespawnPosition(GameObject newRespawnPosition) {
        respawnPosition = newRespawnPosition;
    }

    public void AddLife()
    {
        if (healthPoints < initialHealthPoints)
        {
            healthPoints += 1;
        }
    }
}
