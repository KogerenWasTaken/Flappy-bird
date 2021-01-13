using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float force = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            rb2D.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }

}
   
