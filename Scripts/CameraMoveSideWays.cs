using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveSideWays : MonoBehaviour
{
    [SerializeField]
    Transform[] waypoints;

    [SerializeField]
    float moveSpeed = 2f;

    int waypointIndex = 0;

   
    



    // Start is called before the first frame update
    void Start()
    {
        
        transform.position = waypoints[waypointIndex].transform.position;
       
    }

    private void Update()
    {
        Move();
       
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);
        if( transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex += 1;
        }
        if (waypointIndex == waypoints.Length)
            waypointIndex = 0;
    }
}
