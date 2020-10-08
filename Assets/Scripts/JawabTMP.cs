using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JawabTMP : MonoBehaviour {
    public TextMeshProUGUI jawaban;
    public Button tombol1, tombol2, tombol3, tombol4, tombol5, tombol6, tombol7, tombol8, tombol9, tombol0, tombolHapus, tombolJawab;
    // Start is called before the first frame update
    void Start(){
        jawaban.text = "";
        tombol1.onClick.AddListener(delegate() {klikTombol("1");});
        tombol2.onClick.AddListener(delegate() {klikTombol("2");});
        tombol3.onClick.AddListener(delegate() {klikTombol("3");});
        tombol4.onClick.AddListener(delegate() {klikTombol("4");});
        tombol5.onClick.AddListener(delegate() {klikTombol("5");});
        tombol6.onClick.AddListener(delegate() {klikTombol("6");});
        tombol7.onClick.AddListener(delegate() {klikTombol("7");});
        tombol8.onClick.AddListener(delegate() {klikTombol("8");});
        tombol9.onClick.AddListener(delegate() {klikTombol("9");});
        tombol0.onClick.AddListener(delegate() {klikTombol("0");});
        tombolHapus.onClick.AddListener(delegate() {hapus();});
    }

    // Update is called once per frame
    void Update(){
        
        
    }
    void klikTombol(string masukan){
        jawaban.text = jawaban.text + masukan;
    }
    void hapus(){
        jawaban.text = "";
    }
}
