using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int Score;
    public Text scoreText;
    
    public void RestartGame()
    {

        SceneManager.LoadScene(0);
        Time.timeScale = 1;

    }


}
