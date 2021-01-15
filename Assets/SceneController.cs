using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    bool playerSpawned;
    public GameObject Cube;
    public void Start()
    {
        playerSpawned = false;
    }
    void FixedUpdate()
    {
        if (!playerSpawned) {
            if (Input.GetButton("Submit"))
            {
                SpawnPlayer();
            }
        }
        
    }
    public void SpawnPlayer()
    {
        Instantiate(Cube, positions.instence.points[0].position, positions.instence.points[0].rotation);
        playerSpawned = true;
    }
}
