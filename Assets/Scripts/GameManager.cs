using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // This script will handle the game's state

    public static GameManager Instance { get; private set; }

    [SerializeField]
    private PlayerController player;
    [SerializeField]
    private PlayerHealthController playerHealthController;
    [SerializeField]
    private GameObject playerScoreText;
    [SerializeField]
    private GameObject playerWonText;
    [SerializeField]
    private int playerWinPoints;
    private int playerPoints = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(Instance);
    }

    // Start is called before the first frame update
    private void Start()
    {

    }
    private void Update()
    {
        playerScoreText.GetComponent<Text>().text = $"{playerPoints}/{playerWinPoints}";
    }
   

    // Update is called once per frame
   
}
