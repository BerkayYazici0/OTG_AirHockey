using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMovement : MonoBehaviour
{
    [SerializeField] private float minRange;
    [SerializeField] private float maxRange;
    [SerializeField] private float speed;
    [SerializeField] private bool isMovingLeft;

    private void Update()
    {
        if(transform.position.y > maxRange)
        {
            isMovingLeft = false;
        }
        if(transform.position.y < minRange)
        {
            isMovingLeft = true;
        }
        if(isMovingLeft == true)
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        if(isMovingLeft == false)
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
    }
}
