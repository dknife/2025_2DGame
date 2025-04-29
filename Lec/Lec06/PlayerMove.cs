using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerMove : MonoBehaviour
{
    private Vector2 rawInput;
    private float speed = 5f;

    Vector2 minBounds; // ����Ʈ (0,0)�� ���� ��ǥ
    Vector2 maxBounds; // ����Ʈ (1,1)�� ���� ��ǥ
    void Start()
    {
        Camera cam = Camera.main;
        minBounds = cam.ViewportToWorldPoint(new Vector2(0, 0));
        maxBounds = cam.ViewportToWorldPoint(new Vector2(1, 1));
    }

    void Update()
    {
        // rawInput�� �̿��Ͽ� �����δ�
        // �帥 �ð�: Time.deltaTime
        // �̵��� = �ӵ� x �ð�
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
