using UnityEngine;

public class GameItem : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Game Item Collision");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Game Item Triggering");
    }
}
