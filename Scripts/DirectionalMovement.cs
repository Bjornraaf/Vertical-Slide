using UnityEngine;
using System.Collections;

public class DirectionalMovement : MonoBehaviour
{
    // beweegt de enemy tussen 2 punten

    // instelbaar in inspector;
    [SerializeField] private float speed;
    [SerializeField] private float waypointThreshold;

    [SerializeField] private Transform[] waypoints;
    private Vector3[] currentWaypointPos;

    private int currentWaypointIndex;

    void Start()
    {
        currentWaypointIndex = 0;
        currentWaypointPos = new Vector3[2];

        for(int i = 0; i<currentWaypointPos.Length; i++)
        {
            currentWaypointPos[i] = waypoints[i].position;
        }
    }

    void Update()
    {
        MoveTowardsWaypoint();
        CheckForWaypointRange();
        Debug.Log(currentWaypointIndex);
    }

    void MoveTowardsWaypoint()
    {
        //Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, waypointThreshold);
        transform.position = Vector3.MoveTowards(transform.position, currentWaypointPos[currentWaypointIndex], speed* Time.deltaTime);
    }

    private void CheckForWaypointRange()
    {
        if (Vector3.Distance(transform.position, currentWaypointPos[currentWaypointIndex]) <= waypointThreshold)
        {
            currentWaypointIndex = (currentWaypointIndex +1) % waypoints.Length;
        }
    }
}