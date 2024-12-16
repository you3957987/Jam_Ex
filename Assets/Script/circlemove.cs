using UnityEngine;

public class CircleMove : MonoBehaviour
{
    public float radius; // ���� ������ == 2.8
    public Vector3 center = new Vector3(0, 0, 0); // ���� �߽�
    public float move = 0f; // �ڵ��� ȸ�� ���¸� ��Ÿ���� ����
    public float maxMove = 1.5f; // �ִ� ȸ�� �� (�� ���� ��)
    public float limitedMove; // ���ѵ� ȸ�� ��

    private void Start()
    {
        Application.targetFrameRate = 60; // ������ �ӵ��� 60���� ����
    }

    void Update()
    {
        // ���콺 ��ġ�� ȭ�� ��ǥ���� ���� ��ǥ�� ��ȯ
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // 2D �����̹Ƿ� z���� 0���� ����

        // ���� �߽ɿ��� ���콺 ��ġ������ ���� ���
        Vector3 direction = mousePosition - center;
        direction.Normalize(); // ���� ���͸� ����ȭ

        // ���� �߽ɿ��� ������ �Ÿ���ŭ ������ ��ġ ���
        Vector3 targetPosition = center + direction * radius;

        // �ڵ��� ȸ�� ���� ������Ʈ
        float angle = Vector3.SignedAngle(Vector3.up, direction, Vector3.forward);
        move = Mathf.Clamp(angle / 180f * maxMove, -maxMove, maxMove);

        // ������Ʈ ��ġ ������Ʈ
        if (Mathf.Abs(move) <= limitedMove)
        {
            transform.position = targetPosition;
        }
        else
        {
            // move ���� ���ѵ� ������ ����� �̵����� ����
            move = Mathf.Clamp(move, -limitedMove, limitedMove);
        }
    }
}
