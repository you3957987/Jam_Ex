using UnityEngine;

public class Node3 : MonoBehaviour
{
    public static event System.Action OnNodeDestroyed; // �̺�Ʈ ����


    [SerializeField] private float fallSpeed = 1f; //�������� �ӵ�
    public float destroyHeight = -6f;
    public float top;
    public float bottom;

    public AudioSource nodeaudio;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        nodeaudio = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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
            if (Input.GetKeyDown(KeyCode.O))
            {
                nodeaudio.Play();
                MakeTransparent();
                Debug.Log("a");
                OnNodeDestroyed?.Invoke();// ��尡 �ı��� �� �̺�Ʈ ȣ��
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
