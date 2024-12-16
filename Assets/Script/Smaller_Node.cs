using UnityEngine;

public class SmallerNode : MonoBehaviour
{
    public Vector3 initialScale = new Vector3(7f, 7f, 1f); // �ʱ� ������
    public Vector3 targetScale = new Vector3(1f, 1f, 1f); // ��ǥ ������
    public float shrinkSpeed;// ��� �ӵ�

    public float start_scale;
    public float end_scale;

    void Start()
    {
        // �ʱ� ������ ����
        transform.localScale = initialScale;
    }

    void Update()
    {
        // �������� ���� ����
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, shrinkSpeed * Time.deltaTime);

        // ��ǥ �����Ͽ� �����ϸ� ������Ʈ ����
        if (transform.localScale.x <= 1f)
        {
            Destroy(gameObject);
        }

        // �������� 1.3 ~ 1.7�� �� �����̽� Ű�� ������ ���� ���
        if (transform.localScale.x >= start_scale && transform.localScale.x <= end_scale &&
            transform.localScale.y >= start_scale && transform.localScale.y <= end_scale)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("����");
                Destroy(gameObject);
            }
        }
    }
}