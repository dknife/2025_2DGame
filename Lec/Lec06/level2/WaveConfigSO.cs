using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "WaveConfigSO", menuName = "Scriptable Objects/WaveConfigSO")]
public class WaveConfigSO : ScriptableObject
{
    [SerializeField] List<GameObject> enemyPrefabs;
    [SerializeField] Transform pathPrefab;
    [SerializeField] float moveSpeed = 5.0f;

    // Getters
    public int GetEnemyCount()
    {
        return enemyPrefabs.Count;
    }
    public GameObject GetEnemyPrefab(int idx)
    {
        return enemyPrefabs[idx];
    }
    public Transform GetStartingWaypoint()
    {
        return pathPrefab.GetChild(0);
    }
    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    public List<Transform> GetWaypoints()
    {
        // 后 府胶飘 积己
        List<Transform> waypoints = new List<Transform>();

        foreach(Transform child in pathPrefab)
        {
            waypoints.Add(child);
        }
        return waypoints;
    }
}
