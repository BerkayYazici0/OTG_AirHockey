using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private float horizontalMov;
    private float verticalMov;
    private Vector3 movVec;

    private void Update()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");

        horizontalMov = h * speed * Time.deltaTime;
        verticalMov = v * speed * Time.deltaTime;

        movVec = new Vector3(horizontalMov, verticalMov, 0f);
        transform.Translate(movVec);
    }
}
