using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartMenuButton : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        startButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("TutorialScene");
        });

        quitButton.onClick.AddListener(() =>
        {
            Debug.Log("Quit");
            Application.Quit();
        });
    }
}
