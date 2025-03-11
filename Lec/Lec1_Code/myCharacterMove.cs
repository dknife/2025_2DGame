using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Translate(2.0f, 1.0f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.01f, 0);
        transform.Rotate(0, 0, 0.3f);
    }
}
