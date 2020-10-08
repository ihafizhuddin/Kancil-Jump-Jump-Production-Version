using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUtama : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
    }
    public void playGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void playEndless(){
        SceneManager.LoadScene("LevelPenjumlahanEndless");
    }
    public void quitGame(){
        Application.Quit();
    }
}
