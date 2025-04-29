using UnityEngine;
using System.Collections.Generic;

public class PathFinder : MonoBehaviour
{
    /// //////////////////////
    EnemySpawner enemySpawner;
    WaveConfigSO waveConfigSO;
    /// /////////////////////////
    
    List<Transform> waypoints;
    int waypointIndex = 0;

    private void Awake()
    {
        enemySpawner = FindFirstObjectByType<EnemySpawner>();
    }
    
    void Start()
    {
        waveConfigSO = enemySpawner.GetCurrentWave();

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
        else // ��� waypoint�� �湮�Ͽ���.
        {
            Destroy(gameObject);
        }
    }
}
