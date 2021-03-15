using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float MovementSpeed = 10f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0, 0, MovementSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0, 0, -MovementSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
