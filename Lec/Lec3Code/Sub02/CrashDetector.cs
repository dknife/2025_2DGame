using UnityEngine;

public class CrashDetector : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground") 
        {
            Debug.Log("Hit the ground");

        }
    }
}
