using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondToEnd : MonoBehaviour
{
    private void Start()
    {
        // 59�� �Ŀ� �� �̵�
        Invoke("LoadEndScene", 34f);
    }

    private void LoadEndScene()
    {
        // "1end" �� �ε�
        SceneManager.LoadScene("2end");
    }
}
