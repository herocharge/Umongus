using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float thrust = 1f;
    public float upthrust = 10f;
    public Transform tr;
    public float maxvel = 10f;
    public float off = 0.3f;
    public float maxvely = 10f;
    public SpriteRenderer spr;
    public float dec;
    public float boundx = -2.5f;
    public float bounce = 2f;
    public float vely = 10f;
    public int springoff = 10;
    public int springtime = 0;
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D coll)
    {
        // If the Collider2D component is enabled on the collided object
        float up = upthrust;
        if(coll.collider.tag == "spring"){
        	up*=bounce;
        	Debug.Log("f");
        	rb.velocity = new Vector3(0, vely, 0);
        	springtime = springoff;
        }
	if(coll.transform.position.y <= tr.position.y - off )
		rb.AddForce(new Vector3(0, up, 0), ForceMode2D.Impulse);
    }
    void Update()
    {
        /*if(Input.GetKey("right")){
        	if(rb.velocity.x < maxvel){
			rb.velocity = new Vector3(0, rb.velocity.y, 0);
			rb.AddForce(new Vector3(thrust, 0, 0));
		}
       		spr.flipX = false;
        }
        if(Input.GetKey("left")){
        	if(rb.velocity.x > -maxvel){
        		rb.velocity = new Vector3(0, rb.velocity.y, 0);
			rb.AddForce(new Vector3(-thrust, 0, 0));
		}
        	spr.flipX =  true;
        }*/
        tr.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, tr.position.y, tr.position.z);
        tr.rotation = Quaternion.identity;
        if(tr.position.x < -boundx)tr.position = new Vector3(boundx, tr.position.y, tr.position.z);
	if(tr.position.x > boundx)tr.position = new Vector3(-boundx, tr.position.y, tr.position.z);
	rb.velocity = new Vector2(rb.velocity.x - Mathf.Sign(rb.velocity.x)*dec*Time.deltaTime, rb.velocity.y);
        if((springtime)==0)rb.velocity = new Vector2(rb.velocity.x, Mathf.Min(rb.velocity.y, maxvely));
        else {
        	Debug.Log("yay");
        	springtime--;
        }
    }
}
