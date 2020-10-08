using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Destroyer : MonoBehaviour{
    // private BoxCollider2D box;
    // Start is called before the first frame update
    void Start(){
        // box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update(){}
    void OnTriggerEnter2D(Collider2D other){
        Destroy(other.gameObject);
    }
}
