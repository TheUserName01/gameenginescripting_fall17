using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        //rb = GetComponent<Rigidbody2D>();

        //Debug.Log("Hello. This code is inside of start.");

        //this code teleports object to center
        //transform.position = new Vector3(0,0,0);       
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Called from update!!!");

        
        float HorzInput = Input.GetAxis("Horizontal");
        float speed = 0.2f;
        

        transform.Translate(speed * HorzInput,0,0); 

        if(Input.GetButtonDown("Jump"))
        {
            transform.Translate(0, 6, 0);
        }       
    }
}
