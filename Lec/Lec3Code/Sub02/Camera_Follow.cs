using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    [SerializeField] GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + new Vector3(0, 0, -10.0f);
    }
}
