using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoder : MonoBehaviour
{
    // Start is called before the first frame update
    public void SwitchScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void TitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
