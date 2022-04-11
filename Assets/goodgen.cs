using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goodgen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spring;
    public Transform currtr;
    public Transform playertr;
    private float score = 20;
    public float freq = 100;
    // Update is called once per frame
    void Update()
    {
        if(playertr.position.y > score + freq){
        	score+=freq;
        	Vector3 newpos = new Vector3(Random.Range(-2.5f, 2.5f), currtr.position.y, currtr.position.z);
        	Instantiate(spring, newpos, Quaternion.identity);
        }
    }
}
