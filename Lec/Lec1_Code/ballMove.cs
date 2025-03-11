using UnityEngine;

public class ballMove : MonoBehaviour
{
    float mass = 2.0f;
    float x = -5.0f;
    float y = 0.0f;
    float vx = 0.0f;
    float vy = 0.0f;
    float fx = 0.0f;
    float fy = 0.0f;
    float g = 9.8f;
    float total_time = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fx = 40.0f;
        fy = 40.0f;        
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
        transform.position = new Vector3(x, y, 0);
    }
}
