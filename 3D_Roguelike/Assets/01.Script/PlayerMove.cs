using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    public float moveSpeed;
    private Rigidbody charRigidbody;

    void Start()
    {
        charRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(!Input.GetKeyDown(KeyCode.None))
        {
            Move(); 
        }
    }

    public void Move()
    {
        float hAxis = Input.GetAxisRaw("Horizontal");
        float vAxis = Input.GetAxisRaw("Vertical");

        Vector3 inputDir = new Vector3(hAxis, 0, vAxis).normalized;

        charRigidbody.velocity = inputDir * moveSpeed;

        transform.forward = inputDir;
    }
}