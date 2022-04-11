using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_block : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform tr;
    public float vel = 1f;
    // Update is called once per frame
    void Update()
    {
        tr.position = new Vector3(tr.position.x + vel, tr.position.y, tr.position.z);
        if(tr.position.x > 2.5 || tr.position.x < -2.5)vel*=-1;
    }
}
