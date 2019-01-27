using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    private Rigidbody2D rb2d;


    public float speed;


	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void FixedUpdate()
    {
            float moveHorz = Input.GetAxis("Horizontal");
            float moveVert = Input.GetAxis("Vertical");
            Vector2 movement = new Vector2(moveHorz, moveVert);
            rb2d.AddForce(movement * speed);
    }
}
