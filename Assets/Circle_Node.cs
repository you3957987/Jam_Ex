using UnityEngine;

public class NodeMover : MonoBehaviour
{
    public float moveSpeed = 2f; // �̵� �ӵ�

    void Update()
    {
        // �߽����� �̵�
        Vector3 targetPosition = Vector3.zero;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // �߽ɿ� �����ϸ� ����
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // �ٸ� �ݶ��̴��� �浹 �� ����
        Destroy(gameObject);
    }
}
