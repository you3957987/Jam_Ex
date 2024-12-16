using UnityEngine;
using UnityEngine.UI;

public class FadeImage : MonoBehaviour
{
    [SerializeField] private Image image;          // ���� ���� ������ �̹���
    [SerializeField] private float fadeSpeed = 0.05f;  // �ð��� ���� ��ο����� �ӵ�
    [SerializeField] private float brightenAmount = 0.2f; // ��� �ı� �� ������� ��

    private float alphaValue = 0f;                 // ���� �� �ʱ�ȭ (���� ����)

    private void Start()
    {
        Node.OnNodeDestroyed += Node_OnNodeDestroyed;
    }

    private void OnDestroy()
    {
        Node.OnNodeDestroyed -= Node_OnNodeDestroyed;
    }

    private void Node_OnNodeDestroyed()
    {
        // ��� �ı� �� ����� (���� ����)
        alphaValue -= brightenAmount;
        alphaValue = Mathf.Clamp(alphaValue, 0f, 1f); // ���� �� ����
        Debug.Log($"Node destroyed. Brightened alpha: {alphaValue}");
    }

    private void Update()
    {
        // �ð��� �����鼭 ��ο��� (���� ����)
        alphaValue += fadeSpeed * Time.deltaTime;
        alphaValue = Mathf.Clamp(alphaValue, 0f, 0.95f); // ���� �� ����

        // �̹��� ���� ������Ʈ
        Color currentColor = image.color;
        currentColor.a = alphaValue;
        image.color = currentColor;

        // �����
        Debug.Log($"Alpha value (darkening): {alphaValue}");
    }
}