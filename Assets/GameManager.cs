using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


    // �X�R�A�֘A
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
        scoreText.text = "Score: " + score.ToString();

        Debug.Log("Add 100");

    }

}