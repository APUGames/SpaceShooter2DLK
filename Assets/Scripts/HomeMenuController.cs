using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeMenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject playerScoreText;
    [SerializeField]
    private GameObject playerWonText;

    // Start is called before the first frame update
    public void LoadFirstLevel()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
