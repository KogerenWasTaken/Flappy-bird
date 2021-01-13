using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointGain : MonoBehaviour
{
    public int points = 0;
    public Text pointCount;
    
    // Start is called before the first frame update
    void Start()
    {
        pointCount.text = "Score: " +points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag=="pointBox")
        {
            points += 1;
            pointCount.text = "Score: " + points.ToString();
           
            
        }
    }
}
