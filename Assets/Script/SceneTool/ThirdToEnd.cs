using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdToEnd : MonoBehaviour
{
    private void Start()
    {
        // 59�� �Ŀ� �� �̵�
        Invoke("LoadEndScene", 51f);
    }

    private void LoadEndScene()
    {
        // "1end" �� �ε�
        SceneManager.LoadScene("ending");
    }
}
