using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [Header("UI Game Over")]
    public GameObject UI_GameOver;
    public TextMeshProUGUI txt_score;


    [Header("UI Playing")]
    public GameObject UI_Playing;
    public TextMeshProUGUI txt_scoring;
    public TextMeshProUGUI txt_MAX;

    public static int MAX;
    public static int score;

    public static bool IsGameOver;


    private void Start()
    {
        if (score > MAX)
        {
            MAX = score;
        }
        score = 0;
        IsGameOver = false;
        UI_Playing.SetActive(true);
    }

    private void Update()
    {
        PlayingGame();
        if (IsGameOver)
        {
            UI_Playing.SetActive(false);
            UI_GameOver.SetActive(true);
            txt_score.text = score.ToString();

        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Home()
    {

    }


    public void PlayingGame()
    {
        txt_scoring.text = score.ToString();
        txt_MAX.text = MAX.ToString();
    }

}
