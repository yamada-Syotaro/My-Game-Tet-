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

    // �X�R�A�֘A
    public Text scoreText;
    private int score;
    public int currentScore;
    public int clearScore = 1500;

    // UI�֘A
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

    // �Q�[���J�n�O�̏�Ԃɖ߂�
    private void Initialize()
    {
        // �X�R�A��0�ɖ߂�
        score = 0;
    }

    // �X�R�A�̒ǉ�
    public void AddScore()
    {
        score += 100;
        currentScore = score;
        scoreText.text = "Score: " + currentScore.ToString();
        Debug.Log(currentScore);
    }

    // GameOver�����Ƃ��̏���
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