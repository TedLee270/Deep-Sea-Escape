using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> gameObjects;
    [SerializeField] Transform playerTransform;
    [Header("Wall Layer")]
    [SerializeField] Vector2 boxSize = new Vector2(0.1f, 0.1f); // Size of the box for overlap detection
    [SerializeField] LayerMask wallLayer; 
    [Header("Objects")]
    [SerializeField] float spawnDistance = 10;
    [SerializeField] int maxObjects = 5;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject() {
        int retry = 10;
        
        Vector3 spawnPos = playerTransform.position + new Vector3(Random.Range(-2f,2f), Random.Range(-2f,2f), 0).normalized * spawnDistance;

        if (!Physics2D.OverlapBox(spawnPos, boxSize, 0, wallLayer)) {
            Instantiate(gameObjects[Random.Range(0, gameObjects.Count)], spawnPos, Quaternion.identity);
        }
    }

    public void SpawnObjects() {
        StartCoroutine(SpawnObjectRoutine());
        IEnumerator SpawnObjectRoutine() {
            int counter = 0;
            while(counter < maxObjects) {
                SpawnObject();
                counter++;
                yield return null;
            }
        }
    }
}