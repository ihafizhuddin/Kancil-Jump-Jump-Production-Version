using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetScore : MonoBehaviour{
    public TextMeshProUGUI score;
    public TextMeshProUGUI scoreInMenu;
    
    // Start is called before the first frame update
    void Start(){
        scoreInMenu.text = score.text;
    }

    // Update is called once per frame
    void Update()
    {
        scoreInMenu.text = score.text;
        
    }
}
