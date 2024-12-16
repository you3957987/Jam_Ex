using UnityEngine;
using UnityEditor.Tilemaps;
using UnityEngine.InputSystem.Processors;
using UnityEngine.UI;

public class Node2 : MonoBehaviour
{
    public static event System.Action OnNodeDestroyed;  //�̺�Ʈ ����

    [SerializeField] private float fallSpeed = 1f; //�������� �ӵ�
    public float destroyHeight = -6f;
    public float top;
    public float bottom;

    public AudioSource nodeaudio;
    private SpriteRenderer spriteRenderer;
    
    //FadeImage fade;

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
            if (Input.GetKeyDown(KeyCode.W))
            {
                //nodeaudio.Play();
                MakeTransparent();
                //Debug.Log("a");
                //fade.OnDestroy();
                OnNodeDestroyed?.Invoke();  //��� �ı��� �� �̺�Ʈ ȣ��
            }

            if (Mathf.Abs(transform.position.y - (bottom + top) / 2) < 0.1f && GameOverManager.devMode)
            {
                nodeaudio.Play();
                MakeTransparent();
                OnNodeDestroyed?.Invoke();
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
