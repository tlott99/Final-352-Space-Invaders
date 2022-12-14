using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    private Waypoints Wpoints;
    private int waypointIndex;

    void Start()
    {
        Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
        // GetComponent<Rigidbody2D>().velocity = transform.right *3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards (transform.position, Wpoints.waypoints[waypointIndex].transform.position, speed * Time.deltaTime);
        // Move();
        if(Vector2.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1f){
            waypointIndex++;
        }
    }

    // void Move(){
    //     transform.position = Vector2.MoveTowards (transform.position, Wpoints.waypoints[waypointIndex].transform.position, speed * Time.deltaTime);
    //     if(transform.position == waypoints [waypointIndex].transform.position){
    //         waypointIndex += 1;
    //     }
    //     if (waypointIndex == waypoints.Length){
    //         waypointIndex = 0;
    //     }
    // }
}

