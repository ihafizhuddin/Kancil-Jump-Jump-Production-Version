using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {
    
    public string[] soal;
    public string[] jawaban;
    public Text textStatus;
    public Text textSoal;
    public Text jawabanUser;
    public Button jawabSoalButton;
    public Button pauseButton;
    public bool play=true;
    public int indexSoal = 0;
    public Slider waktu;
    public Timer timer;
    public int progres = 0;
    public Text nilai;
    public float score = 0;
    // public Jawab tombol;
    public GameObject gameButton;
    public GameObject gameOverPanel;
    public Text menuTextHeader;
    public Text ScoreText;
    //public delegate void RestartRounds();
    //public static event RestartRounds RoundComplete;
    
    // Start is called before the first frame update
    void Start() {
        // waktu = gameObject.GetComponent<Slider>();
        // timer = gameObject.GetComponent<Timer>();
        acakSoal();
        textSoal.text = soal[0] + " : ";
        // jawabSoalButton.onClick.AddListener(delegate {jawabSoal();});
        jawabSoalButton.onClick.AddListener(delegate() {jawabSoal();});
        pauseButton.GetComponentInChildren<Text>().text = "pause";
        pauseButton.onClick.AddListener(delegate() {pausingGame();});
        gameOverPanel.active = false;

    }

    // Update is called once per frame
    void Update() {
        if(timer.actualTime == 0){
            gameOver();
        }else if(progres == 10){
            menang();
        }
    }

    void acakSoal(){
        for(int i = 0; i < soal.Length ; i++){
            string temp = soal[i];
            string temp2 = jawaban[i];
            int indexPenukar = Random.Range(i, soal.Length);
            soal[i] = soal[indexPenukar];
            soal[indexPenukar] = temp;
            jawaban[i] = jawaban[indexPenukar];
            jawaban[indexPenukar] = temp2;
            
        }
    }

    void jawabSoal(){
        if(jawabanUser.text == jawaban[indexSoal]){
            progres++;
            nextSoal();
        }else if(progres == 10){
            menang();
        }
        else{
            textStatus.text = "Salah Menjawab";
            jawabanUser.text = "";
            // Time.timeScale = 0;
        }
    }
    void nextSoal(){
        
        if(++indexSoal < soal.Length){
            score+= timer.actualTime;
            //Debug.Log(score);
            nilai.text = ((int)score).ToString();
            textStatus.text = progres.ToString();
            jawabanUser.text = "";
            textSoal.text = soal[indexSoal] + " : ";
            timer.resetTimer();
        }else if(progres == 10){
            textStatus.text = "menang";
        }
    }
    void gameOver(){
        //GetComponent<Jawab>().enabled = false;
        gameButton.active = false;
        textStatus.text = "Game Over";
        timer.play = false;
        timer.pauseTimer();
        menuTextHeader.text = "Game Over";
        ScoreText.text = ((int)score).ToString();
        gameOverPanel.active = true;

    }
    void menang(){
        //GetComponent<Jawab>().enabled = false;
        gameButton.active = false;
        textStatus.text = "Menang";
        timer.play = false;
        menuTextHeader.text = "Victory";
        ScoreText.text = ((int)score).ToString();
        gameOverPanel.active = true;
    }
    void pausingGame(){
        play = !play;
        if(play){
            resumeGame();
        }else{
            pauseGame();
        }
    }
    void pauseGame(){
        //timer.pauseTimer();
        timer.play = false;
        pauseButton.GetComponentInChildren<Text>().text = "resume";
        gameButton.active = false;
        
        
    }
    void resumeGame(){
        //timer.resumeTimer();
        timer.play = true;
        pauseButton.GetComponentInChildren<Text>().text = "pause";
        gameButton.active = true;
    }
    void activateGameOverPanel(){

    }
    string getJawaban(int index){
        return jawaban[index];
    }
    
}
