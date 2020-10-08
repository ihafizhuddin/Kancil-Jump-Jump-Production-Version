using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour{
    // Start is called before the first frame update
    public GameObject[] spawnedObject;
    void Start(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnObject(){
        foreach (GameObject obj in spawnedObject){
            GameObject newObj = Instantiate(obj, new Vector2(gameObject.transform.position.x,obj.transform.position.y),Quaternion.identity);
            newObj.SetActive(true);
        }
    }
}
