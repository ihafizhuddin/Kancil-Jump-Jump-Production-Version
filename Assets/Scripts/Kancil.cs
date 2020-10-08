using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kancil : MonoBehaviour{
    public float jumpPower;
    Rigidbody2D rigid;// = gameObject.GetComponent<Rigidbody2D>();
    // Start is called before the first frame update
    Animator anim;
    void Start(){
       // rb = GetComponent<rigidbody2D>();
       rigid = GetComponent<Rigidbody2D>();
       anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void lompatMovement(){
        Debug.Log("Lompat sekuat " + jumpPower);
        // delay(1000);
        rigid.AddForce(Vector2.up * jumpPower);
        rigid.AddForce(Vector2.right * jumpPower);
    }

    public void lompatAnimation(){
        
        Debug.Log("Kancil Lompat");
        // anim.enabled= true;
        // nonActive(1);
        
        anim.SetTrigger("Active");
        
        // anim.ResetTrigger("Active");
        // rigid.AddForce(new Vector2(0,100));
        // rigid.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
    //    rb.addForce(new Vector2(0,10), ForceMode2D.Impulse);
    }
    IEnumerator delay(int seconds){
        yield return new WaitForSeconds(seconds);
        // anim.enabled = false;
    }
}
