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


 private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "air")
        {
            // Uncomment to play an audio clip
            // GetComponent<AudioSource>().Play();

            // Uncomment to increase speed by 0.3f
            // speed = speed + 0.3f;

            // Uncomment to update the UI text
            // UItexthere++;
            // some.text = "" + UItexthere;

            Destroy(other.gameObject); // Destroy the "air" GameObject
        }
    }
}
