
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;

    public Text ScoreText;

    public GameObject playButton;

    public GameObject gameOver;

    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
        gameOver.SetActive(false);
    }

    public void Play()
    {
        score = 0;
        ScoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f; // Set time = 0 means pause the game
        player.enabled = false;
    }


    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();

    }


    public void IncreaseScore()
    {
        score++;
        ScoreText.text = score.ToString();

    }

}
