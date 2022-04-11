using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertrack : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playertr;
    public Rigidbody2D rb;
    void Start(){
    	playertr = GameObject.FindWithTag("player").transform;
    	rb = GameObject.FindWithTag("player").GetComponent<Rigidbody2D>();
    }
    public BoxCollider2D bx;
    public Transform blocktr;

    public float off = 0.8f;
    public float h = 10f;
    // Update is called once per frame
    void Update()
    {
     	   if(blocktr.position.y + off <= playertr.position.y && rb.velocity.y <= 0){
     	   	bx.enabled = true;
     	   }
     	   else{
     	   	bx.enabled = false;
     	   }
     	   
     	   if(playertr.position.y - blocktr.position.y > h){
     	   	Destroy(this.gameObject);
     	   }
    }
}
