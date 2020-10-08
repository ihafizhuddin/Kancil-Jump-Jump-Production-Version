using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManagerTMP : MonoBehaviour {
    
    public string[] soal;
    public string[] jawaban;
    public TextMeshProUGUI textStatus;
    public TextMeshProUGUI textSoal;
    public TextMeshProUGUI jawabanUser;
    public Button jawabSoalButton;
    public Button pauseButton;
    public bool play=true;
    public int indexSoal = 0;
    public Slider waktu;
    public TimerTMP timer;
    public int progres = 0;
    public TextMeshProUGUI nilai;
    public float score = 0;
    // public Jawab tombol;
    public GameObject gameButton;
    public GameObject gameOverPanel;
    public GameObject victoryPanel;
    public TextMeshProUGUI menuTextHeader;
    public TextMeshProUGUI ScoreText;
    public AudioSource wrongAnswer;
    public AudioSource rightAnswer;
    public AudioSource victorySound;
    public AudioSource gameOverSound;
    //public delegate void RestartRounds();
    //public static event RestartRounds RoundComplete;
    public Kancil kancil;
    public BuayaScript[] buaya;
    
    // Start is called before the first frame update
    void Start() {
        // waktu = gameObject.GetComponent<Slider>();
        // timer = gameObject.GetComponent<Timer>();
        acakSoal();
        textSoal.text = soal[0] ;
        // jawabSoalButton.onClick.AddListener(delegate {jawabSoal();});
        jawabSoalButton.onClick.AddListener(delegate() {jawabSoal();});
        pauseButton.GetComponentInChildren<TextMeshProUGUI>().text = "||";
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
            kancil.lompatMovement();
            rightAnswer.Play();
            kancil.lompatAnimation();
            nextSoal();
        }else if(progres == 10){
            menang();
        }
        else{
            textStatus.text = "Salah Menjawab";
            jawabanUser.text = "";
            wrongAnswer.Play();
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
            textSoal.text = soal[indexSoal] ;
            timer.resetTimer();
        }else if(progres == 10){
            textStatus.text = "menang";
        }
    }
    void gameOver(){
        //GetComponent<Jawab>().enabled = false;
        for(int i = 0 ; i < buaya.Length ; i++){
            buaya[i].makanKancil();
        }
        gameButton.active = false;
        textStatus.text = "Game Over";
        timer.play = false;
        timer.pauseTimer();
        // menuTextHeader.text = "Game Over";
        // ScoreText.text = ((int)score).ToString();
        gameOverPanel.active = true;

    }
    void menang(){
        //GetComponent<Jawab>().enabled = false;
        gameButton.active = false;
        textStatus.text = "Menang";
        timer.play = false;
        // victoryPanel.transform.Find("menuTextHeader").gameObject.text = "Victory";
        // menuTextHeader.text = "Victory";
        // ScoreText.text = ((int)score).ToString();
        
        // victorySound.PlayOneShot(victorySound.clip , 1f);
        // victorySound.Play();
        victoryPanel.active = true;
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
        pauseButton.GetComponentInChildren<TextMeshProUGUI>().text = "I>";
        gameButton.active = false;
        //textSoal.text.active = false;
        //jawabanUser.text.active = false;
        
    }
    void resumeGame(){
        //timer.resumeTimer();
        timer.play = true;
        pauseButton.GetComponentInChildren<TextMeshProUGUI>().text = "||";
        gameButton.active = true;
        //textSoal.text.active = true;
        //jawabanUser.text.active = true;

    }
    void activateGameOverPanel(){

    }
    string getJawaban(int index){
        return jawaban[index];
    }
    
}
