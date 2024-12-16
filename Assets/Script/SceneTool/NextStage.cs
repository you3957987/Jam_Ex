using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    public Sprite[] sprites;  // Sprite �迭
    public Canvas canvas;     // Canvas ��ü

    private SpriteRenderer spriteRenderer;  // SpriteRenderer ������Ʈ ����

    int next = 0;

    private void Start()
    {
        // SpriteRenderer ������Ʈ�� �����ɴϴ�.
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer ������Ʈ�� �� ������Ʈ�� �����ϴ�!");
            return;
        }

        // 1�� �Ŀ� ��������Ʈ�� ����
        Invoke("ChangeSprite", 3f);
    }

    private void Update()
    {
        if (next == 1)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Jam");
            }
        }
    }

    private void ChangeSprite()
    {
        // sprites[1]�� ��������Ʈ ����
        if (sprites != null && sprites.Length > 1)
        {
            spriteRenderer.sprite = sprites[1];
            canvas.gameObject.SetActive(true);
            next = 1;
        }
        else
        {
            Debug.LogError("sprites �迭�� ����ְų� sprites[1]�� �������� �ʽ��ϴ�!");
        }
    }
}
