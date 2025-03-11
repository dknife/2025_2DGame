using UnityEngine;

public class ballMove : MonoBehaviour
{
    float mass = 2.0f;
    float x = -5.0f;
    float y = 0.0f;
    float vx = 0.0f;
    float vy = 0.0f;
    [SerializeField] float fx = 10.0f;
    [SerializeField] float fy = 20.0f;
    float g = 9.8f;
    float total_time = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       x = transform.position.x;
       y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        total_time += dt;
        if (total_time > 0.5f) {
            fx = fy = 0.0f;
        }
        float ax = fx / mass;
        float ay = fy / mass - g;
        vx += ax * dt;
        vy += ay * dt;
        x += vx * dt;
        y += vy * dt;
        float xLim = 9.0f;
        float yLim = 4.0f;
        if (y < -yLim) {
            vy = -vy;
            y = -yLim + (-yLim - y );
        }
        if (x > xLim) {
            vx = -vx;
            x = xLim - (x - xLim);
        }
        if (x < -xLim) {
            vx = -vx;
            x = -xLim + (-xLim - x);
        }
        transform.position = new Vector3(x, y, 0);
    }
}
