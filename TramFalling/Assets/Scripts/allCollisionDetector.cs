using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allCollisionDetector : MonoBehaviour
{
    [SerializeField] private GameObject trampolineTarget;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float movementSpeed = 5f;
    private float counter = 0f;
    private bool isGrounded = true;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject != null)
        {
            if(other.gameObject.tag == trampolineTarget.tag)
            {
                toJump(other);
            }
            if(other.gameObject.tag == "floor")
            {
                isGrounded = true;
            }
        }

    }
    void toJump(Collision collisionInfo)
    {
        if(collisionInfo.gameObject != null)
        {
            if(isGrounded == true)
            {
                rb.AddForce(new Vector3(0, movementSpeed + counter, 0), ForceMode.Impulse);
                counter ++;
                Debug.Log(counter);
                isGrounded = false;
            }
        }
    }
}
