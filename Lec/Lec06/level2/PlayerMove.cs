using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerMove : MonoBehaviour
{
    private Vector2 rawInput;
    private float speed = 5f;

    Vector2 minBounds; // 뷰포트 (0,0)의 월드 좌표
    Vector2 maxBounds; // 뷰포트 (1,1)의 월드 좌표
    void Start()
    {
        Camera cam = Camera.main;
        minBounds = cam.ViewportToWorldPoint(new Vector2(0, 0));
        maxBounds = cam.ViewportToWorldPoint(new Vector2(1, 1));
    }

    void Update()
    {
        // rawInput을 이용하여 움직인다
        // 흐른 시간: Time.deltaTime
        // 이동량 = 속도 x 시간
        Vector2 moveDelta = rawInput * speed * Time.deltaTime;
        Vector2 newPos = (Vector2) transform.position + moveDelta;
        newPos.x = Mathf.Clamp(newPos.x,minBounds.x,maxBounds.x);
        newPos.y = Mathf.Clamp(newPos.y,minBounds.y,maxBounds.y);
        transform.position = newPos;
        

    }

    void OnMove(InputValue value)
    {
        rawInput = value.Get<Vector2>();
    }
}
