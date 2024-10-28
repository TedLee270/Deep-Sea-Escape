using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScubaDiver : MonoBehaviour
{
    Rigidbody2D rb;
    [Header("Movement")]
    [SerializeField] float speed = 10;
    [SerializeField] float speedLimit = 10;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        if(rb.velocity.magnitude > speedLimit) {
            rb.velocity = rb.velocity.normalized * speedLimit;

        }
    }

    public void Move(Vector3 movement) {
        rb.AddForce(movement * speed);  
    }
}
