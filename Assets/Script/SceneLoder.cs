using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoder : MonoBehaviour
{
    public AudioSource AudioSource;
    public void SwitchScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void TitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
