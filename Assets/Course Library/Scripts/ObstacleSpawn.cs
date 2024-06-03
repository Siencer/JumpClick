using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    private int obstacleIndex;
    Vector3 spawnPosition = new Vector3(33, 0, 0);
    private float startDelay = 0;
    private float spawnInterval = 2;

    public GameObject[] obstacles;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            obstacleIndex = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[Random.Range(0, obstacles.Length)], spawnPosition, obstacles[obstacleIndex].transform.rotation);

        }
    }
}
