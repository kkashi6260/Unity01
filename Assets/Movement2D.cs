using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float moveSpeed = 5.0f;                              // 속도
    private Vector3 moveDirection = Vector3.zero;     // 이동백터

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");       // 왼쪽 오른쪽 left right a d
        float y = Input.GetAxisRaw("Vertical");           // 위 아래 up down w s

        moveDirection = new Vector3(x, y, 0);       //movedirection에 이동값  x y 받음

        transform.position += moveDirection * moveSpeed * Time.deltaTime; // 움직이는 위치 = 현좌표 * 움직이는 속도 *  업데이트 사이의 시간
    }
}
