using UnityEngine;

public class BoarderControl : MonoBehaviour
{
    [SerializeField] float torqueAmount = 10.0f;
    Rigidbody2D rb2d;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow) ) {
            rb2d.AddTorque(torqueAmount * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) ) {
            rb2d.AddTorque(-torqueAmount * Time.deltaTime);
        }
    }
}
