using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class followPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playertr;
    public Transform camtr;
    private float maxpos =0;
    public float killdis = 10;
    public float stopdis = 5;
    private bool ok = true;
    void Start(){
    	ok = true;
    }
    // Update is called once per frame
    void Update()
    {
    	Vector3 pos = playertr.position;
    	maxpos = Mathf.Max(pos.y, maxpos);
        if(ok)camtr.position = new Vector3(0, pos.y, -10);
        if(pos.y < maxpos - stopdis){
        	ok = false;

        }
        if(pos.y < maxpos - killdis){
                Scene scene = SceneManager.GetActiveScene(); 
                SceneManager.LoadScene(scene.name);
	}
    }
}
