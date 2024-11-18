using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 8f;

    private Transform target;
    private int wavepointIndex = 0;

    public GameObject FindCamera;
    public Economy EndScreen;

    void Start()
    {
        target = Waypoints.points[0];
        FindCamera = GameObject.Find("MoveCamera");
        EndScreen = FindCamera.GetComponent<Economy>();
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        if (dir != Vector3.zero)
        {
            Quaternion lookRotation = Quaternion.LookRotation(-dir);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);
        }
        
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f){
            GetNextWaypoint();
        }
    }


    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            EndScreen.EnemyPassed();
        }
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

}
