using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1.0f;
    [SerializeField] float moveSpeed = 1.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = -Input.GetAxis("Horizontal");
        float moveAmount = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, steerSpeed*steerAmount);
        transform.Translate(0, moveSpeed * moveAmount, 0);
    }
}
