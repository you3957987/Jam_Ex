using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstToEnd : MonoBehaviour
{
    private void Start()
    {
        // 59�� �Ŀ� �� �̵�
        Invoke("LoadEndScene", 59f);
    }

    private void LoadEndScene()
    {
        // "1end" �� �ε�
        SceneManager.LoadScene("1end");
    }
}
