using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public SpriteRenderer sprite;
    public Rigidbody2D rigid;
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigid.velocity = Vector2.up;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            rigid.velocity = Vector2.down;
        }
        else
        {
            rigid.velocity = Vector2.zero;
        }
    }

    private void OnMouseDown()
    {
   
      sprite.color = Color.red;
      rigid = GetComponent<Rigidbody2D>();
    }
}
