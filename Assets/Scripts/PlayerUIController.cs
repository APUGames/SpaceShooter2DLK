using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerUIController : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private PlayerHealthController playerHealthController;
    [SerializeField]
    private GameObject playerHealthControl;
    [SerializeField]
    private GameObject playerScoreText;
    [SerializeField]
    private GameObject playerWonText;
    [SerializeField]
    private int playerWinPoints;

    private bool playerDead = false;

    public int playerPoints = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerPoints = 0;
        playerWonText.SetActive(false);
    }
    private void Update()
    {
        playerScoreText.GetComponent<Text>().text = playerPoints.ToString();
        //playerScoreText = GameObject.Find("PlayerScoreText");
        //playerWonText = GameObject.Find("PlayerWonText");
        if (playerHealthController != null && playerHealthController.GetHealth() <= 0)
        {
            playerDead = true;
        }

        if (playerPoints >= playerWinPoints)
        {
            playerWonText.SetActive(true);
        }
        if (playerDead == true)
        {
            SceneManager.LoadScene("Title");
        }
    }

}
