using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuayaScript : MonoBehaviour{
    // Rigidbody2D rigid;
    BoxCollider2D box;
    Animator anim;
    void Awake(){
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start(){
        // rigid = GetComponent<Rigidbody2D>();
        
        box = GetComponent<BoxCollider2D>();
        // Debug.Log("Buaya Makan Kancil");
        // anim.SetTrigger("Makan");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void makanKancil(){
        Debug.Log("Buaya Makan Kancil");
        anim.SetTrigger("Makan");
        box.enabled = false;
        // rigid.isKinematic = true;
    }
    void activateAnimation(){

    }
}
