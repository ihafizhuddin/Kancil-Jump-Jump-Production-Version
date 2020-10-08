using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerPengurangan : GameManagerPenjumlahan{
    protected override void nextSoal(){
        if(progres < 10){
            score += timer.actualTime;
            ScoreText.text = ((int)score).ToString();
            int a = (int)Random.Range(2 , batasAtasAngkaPertanyaanA);
            int b = (int)Random.Range(1 , a);
            jawaban = a - b;
            textStatus.text = progres.ToString();
            jawabanUser.text  = "";
            textSoal.text= a + " - " + b + " = ";
            timer.resetTimer();
        }else if(progres == 10){
            textStatus.text = "menang";
            menang();
        }
    }
}
