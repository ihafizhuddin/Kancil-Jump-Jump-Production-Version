using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerTMP : MonoBehaviour{
    public float width;
    public float totalTime = 5;
    public float actualTime;
    public Slider waktu;
    public TextMeshProUGUI angkaWaktu;
    public bool play = false;
    // Start is called before the first frame update
    void Start(){
        waktu = GetComponent<Slider>();
        actualTime = totalTime;
        angkaWaktu.text = totalTime.ToString();
        play = true;
    }

    // Update is called once per frame
    void Update(){
        if(play){
            playTimer();
        }else{
            actualTime = actualTime;
        }
        
        
    }
    public void resetTimer(){
        Time.timeScale = 1;
        actualTime = totalTime;
    }
    public void pauseTimer(){
        Time.timeScale = 0;
    }
    public void resumeTimer(){
        Time.timeScale = 1;
    }
    public void playTimer(){
        Time.timeScale = 1;
        if(actualTime > 0){
            actualTime -= Time.deltaTime;
            angkaWaktu.text = ((int)actualTime+1).ToString();
            waktu.value = actualTime/totalTime;
        }else if(actualTime <= 0){
            actualTime = 0;
            angkaWaktu.text = actualTime.ToString();
        }
    }
    
}
