using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private Image image;  // ���� ���� Ȯ���� �̹���
    [SerializeField] private GameObject back;
    private bool isTransitioning = false;  // �� ��ȯ �ߺ� ������ �÷���
    [SerializeField] private float backgroundThreshold = 8f;

    public static bool devMode = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            devMode = !devMode;
            Debug.Log("devMode");
        }

        // �̹����� ���� �� ��������
        float currentAlpha = image.color.a;

        // ���� ���� 1 �̻��̰� ���� ��ȯ ���� �ƴ� ���
        if (currentAlpha >= 1f && !isTransitioning || Mathf.Abs(back.transform.position.x) > backgroundThreshold)
        {
            isTransitioning = true;  // ��ȯ ���� �÷��� ����
            StartCoroutine(WaitAndLoadScene(3f));  // 3�� �� �� ��ȯ
        }
    }

    private IEnumerator WaitAndLoadScene(float waitTime)
    {
        Debug.Log("Waiting for " + waitTime + " seconds...");
        yield return new WaitForSeconds(waitTime);  // 3�� ���

        SceneManager.LoadScene("GameOverScene");  // �� �ε�
    }
}