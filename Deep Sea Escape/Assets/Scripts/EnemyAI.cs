using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


void OnTriggerEnter2D(Collider2D other){
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//SceneManager.LoadScene("Main Menu");
//Debug.Log("Collision Detected!");
}


}
