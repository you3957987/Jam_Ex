using UnityEngine;

public class Node2 : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 1f; //�������� �ӵ�
    public float destroyHeight = -6f;
    public float top;
    public float bottom;

    void Update()
    {
        //�Ʒ��� ������
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        // ȭ�� �Ʒ��� ������� ��� ����
        if (transform.position.y < destroyHeight)
        {
            Destroy(gameObject);
        }

        if (transform.position.y >= bottom && transform.position.y <= top)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Destroy(gameObject);
                Debug.Log("a");
            }

        }

    }
}
