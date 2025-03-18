using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] GameObject myCar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = myCar.transform.position + new Vector3(0, 0, -10.0f);
        transform.rotation = myCar.transform.rotation;
    }
}
