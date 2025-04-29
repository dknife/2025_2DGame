using UnityEngine;
using System.Collections.Generic;

public class PathFinder : MonoBehaviour
{
    [SerializeField] WaveConfigSO waveConfigSO;
    List<Transform> waypoints;
    int waypointIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        waypoints = waveConfigSO.GetWaypoints();
        transform.position = waypoints[waypointIndex].position;
    }

    // Update is called once per frame
    void Update()
    {
        FollowPath();
    }

    void FollowPath()
    {
        if(waypointIndex < waypoints.Count)
        {
            Vector3 targetPosition = waypoints[waypointIndex].position;
            float delta = waveConfigSO.GetMoveSpeed() * Time.deltaTime;
            Vector3 currentPos = transform.position;
            transform.position = Vector2.MoveTowards(
                currentPos, targetPosition, delta
                );

            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }

        }
        else // 모든 waypoint를 방문하였다.
        {
            Destroy(gameObject);
        }
    }
}
