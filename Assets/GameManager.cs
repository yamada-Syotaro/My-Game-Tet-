using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


    // スコア関連
    public Text scoreText;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {

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
        scoreText.text = "Score: " + score.ToString();

        Debug.Log("Add 100");

    }

}