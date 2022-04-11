using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject block;
    public GameObject moving;
    public Transform currtr;
    public Transform playertr;
    float score = 0f;
    public float inc = 10f;
    // Update is called once per frame
    void Update()
    {
	    if(playertr.position.y > score + inc){
		score+=inc;
	    	int ran = (int)Mathf.Floor(Random.Range(0, 1.5f));
	    	switch(ran){
			case 0 : 
					for(int i = 0; i < Random.Range(1, 4);i++){
						float randomval = Random.Range(-2.5f, 2.5f);
						Instantiate(block, new Vector3(randomval , currtr.position.y, 0), Quaternion.identity);
					}
				 
				 break;
			case 1 : float randomva = Random.Range(-2.5f, 2.5f);
				 Instantiate(moving, new Vector3(randomva , currtr.position.y, 0), Quaternion.identity);
				 break;
		}
        }
    }
}
