using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200.0f;
    [SerializeField] float moveSpeed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = -Input.GetAxis("Horizontal") * Time.deltaTime ;
        float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime ;
        transform.Rotate(0, 0, steerSpeed * steerAmount );
        transform.Translate(0, moveSpeed * moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "rock")
        {
            Debug.Log("Rock Collision! Energy Decresed!");
        }
        else
        {
            Debug.Log("No Problem!!!");
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "item")
        {
            Destroy(collision.gameObject);
        }
    }
}
