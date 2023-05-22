using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Blue"))
        {
            //top itilecek
            transform.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.1f, 0));
        }
        if (collision.gameObject.CompareTag("Red"))
        {
            //top itilecek
            transform.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-0.1f, 0));
        }
    }
   
}
