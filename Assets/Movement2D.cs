using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float moveSpeed = 5.0f;                              // �ӵ�
    private Vector3 moveDirection = Vector3.zero;     // �̵�����

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");       // ���� ������ left right a d
        float y = Input.GetAxisRaw("Vertical");           // �� �Ʒ� up down w s

        moveDirection = new Vector3(x, y, 0);       //movedirection�� �̵���  x y ����

        transform.position += moveDirection * moveSpeed * Time.deltaTime; // �����̴� ��ġ = ����ǥ * �����̴� �ӵ� *  ������Ʈ ������ �ð�
    }
}
