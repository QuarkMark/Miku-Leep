using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class LeekMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadzone = -45;
 

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
    }
}