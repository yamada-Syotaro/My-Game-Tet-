using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Spawn;
    public AudioClip AudioClip;
    AudioSource AudioSource;

    // スコア関連
    public Text scoreText;
    private int score;
    public int currentScore;
    public int clearScore = 1500;

    // UI関連
    public GameObject GamePauseUI;
    public GameObject GameOverUI;
    public GameObject GameClearUI;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
        AudioSource = GetComponent<AudioSource>();
        AudioSource.Play();
    }

    // ゲーム開始前の状態に戻す
    private void Initialize()
    {
        // スコアを0に戻す
        score = 0;
    }

    // スコアの追加
    public void AddScore()
    {
        score += 100;
        currentScore = score;
        scoreText.text = "Score: " + currentScore.ToString();
        Debug.Log(currentScore);
    }

    // GameOverしたときの処理
    public void GameOver()
    {
        GameOverUI.active = true;
        Time.timeScale = 0f;
        Spawn.active = false;
    }

    public void GamePause()
    {
        GamePauseToggle();
    }

    public void GamePauseToggle()
    {
        GamePauseUI.SetActive(!GamePauseUI.activeSelf);

        if (GamePauseUI.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}