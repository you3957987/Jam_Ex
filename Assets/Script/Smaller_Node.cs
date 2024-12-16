using UnityEngine;

public class SmallerNode : MonoBehaviour
{
    public Vector3 initialScale;
    public Vector3 targetScale;
    public float shrinkSpeed;// ��� �ӵ�

    public float start_scale;
    public float end_scale;

    public AudioSource smallaudio;
    private SpriteRenderer spriteRenderer;

    private float creationTime;

    void Start()
    {
        // �ʱ� ������ ����
        transform.localScale = initialScale;
        smallaudio = gameObject.GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        creationTime = Time.time; // ���� �ð� ���
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
                float elapsedTime = Time.time - creationTime;
                Debug.Log("Node ���� �ð�: " + elapsedTime + "��");
                //Debug.Log("����");
                smallaudio.Play();
                MakeTransparent();
                //Destroy(gameObject);
            }
        }
    }

    void MakeTransparent()
    {
        Color color = spriteRenderer.color;
        color.a = 0f; // ���� ���� 0���� �����Ͽ� ������ �����ϰ� ����
        spriteRenderer.color = color;
    }
}