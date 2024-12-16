using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private Image image;  // ���� ���� Ȯ���� �̹���
    private bool isTransitioning = false;  // �� ��ȯ �ߺ� ������ �÷���

    private void Update()
    {
        // �̹����� ���� �� ��������
        float currentAlpha = image.color.a;

        // ���� ���� 1 �̻��̰� ���� ��ȯ ���� �ƴ� ���
        if (currentAlpha >= 1f && !isTransitioning)
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