using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    private float scr = 0;
    public Transform player;
    public TextMeshProUGUI txt;
    // Update is called once per frame
    void Update()
    {
        scr = Mathf.Max(scr, player.position.y);
        txt.text = (Mathf.Floor(scr)).ToString();
    }
}
