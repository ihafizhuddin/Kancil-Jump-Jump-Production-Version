using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void nextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void restartGame(){
        Scene current = SceneManager.GetActiveScene();
        SceneManager.LoadScene(current.name);
    }
    public void backToMainMenu(){
        SceneManager.LoadScene(0);
    }
    public void exitGame(){
        Application.Quit();
    }

}
