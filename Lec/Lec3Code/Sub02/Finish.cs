using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="Player")
        {
            Debug.Log("You Win!");
        }
    }
}
