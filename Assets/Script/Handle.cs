using UnityEngine;

public class Handle : MonoBehaviour
{

    public CircleMove circle;


    // Update is called once per frame
    void Update()
    {
        // ȸ�� ���� ��� (1.5�� �� 180��, -1.5�� �� -180��)
        float rotationAngle = circle.move * 120f; // 1.5 * 120 = 180��, -1.5 * 120 = -180��

        // �߽��� �������� ȸ��
        transform.rotation = Quaternion.Euler(0, 0, rotationAngle);
    }
}
