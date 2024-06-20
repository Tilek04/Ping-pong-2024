using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float Speed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        sendBallRandomDirection();

    }

    private void sendBallRandomDirection()
    {
        rigidbody2D.velocity = Vector3.zero;
        rigidbody2D.isKinematic = true;
        transform.position = Vector3.zero;
        rigidbody2D.isKinematic = false;

        Vector2 newBallVector = new Vector2();
        newBallVector.x = Random.Range(-1f, 1f);
        newBallVector.y = Random.Range(-1f, 1f);
        rigidbody2D.velocity = newBallVector.normalized * Speed;
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyUp(KeyCode.Space))
        {
            sendBallRandomDirection();
        }  
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Movement>() == null)
            return;
        collision.gameObject.GetComponent<Movement>().speed *= 1.1f;
        rigidbody2D.velocity *= 1.1f;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.position.x > 0)
        {
            Debug.Log("Player Left +1");
        }
        else {
            Debug.Log("Player Right +1");
        }
    }
}


