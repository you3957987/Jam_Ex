using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
