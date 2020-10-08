using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerPenjumlahanEndless : GameManagerPenjumlahan{
    public Spawner spawner;
    // Update is called once per frame
    protected override void Update() {
        if(timer.actualTime == 0){
            gameOver();
        }
    }
    protected override void nextSoal(){
        if(progres % 2 == 0){
            batasAtasAngkaPertanyaanA++;
        }else{
            batasAtasAngkaPertanyaanB++;
        }
        if(progres % 10 == 0 && timer.totalTime > 3f){
            timer.totalTime -= 0.5f;
        }
        score += timer.actualTime;
        ScoreText.text = ((int)score).ToString();
        int a = (int)Random.Range(1 , batasAtasAngkaPertanyaanA);
        int b = (int)Random.Range(1 , batasAtasAngkaPertanyaanB);
        jawaban = a + b;
        textStatus.text = progres.ToString();
        jawabanUser.text  = "";
        textSoal.text= a + " + " + b + " = ";
        timer.resetTimer();
        // if(progres < 10){
            
        // }else if(progres == 10){
        //     textStatus.text = "menang";
        //     menang();
        // }
    }
    protected override void jawabSoal(){
        if(jawabanUser.text == jawaban.ToString()){
            kancil.lompatMovement();
            rightAnswer.Play();
            kancil.lompatAnimation();
            progres++;
            nextSoal();
            spawner.spawnObject();
        }else{
            textStatus.text = "Salah Menjawab";
            jawabanUser.text = "";
            wrongAnswer.Play();
            // Time.timeScale = 0;
        }
    }
}
