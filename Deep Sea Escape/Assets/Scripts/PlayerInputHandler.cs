using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] ScubaDiver scubaDiver;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate() {
        Vector3 movement = Vector3.zero;
        if(Input.GetKey(KeyCode.W)) {
            movement += new Vector3(0,1,0);
        }
        if(Input.GetKey(KeyCode.S)) {
            movement += new Vector3(0,-1,0);
        }
        if(Input.GetKey(KeyCode.A)) {
            movement += new Vector3(-1,0,0);
            spriteRenderer.flipX = (direction == -1);
        }
        if(Input.GetKey(KeyCode.D)) {
            movement += new Vector3(1,0,0);
            spriteRenderer.flipX = (direction == 1);
        }
        
        scubaDiver.Move(movement);
    }
}
