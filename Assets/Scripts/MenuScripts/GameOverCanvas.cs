using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverCanvas : MonoBehaviour
{
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
