using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public static SceneController instence;

    bool playerSpawned;
    public GameObject Cube;

    public bool isPausing;
    public bool isPause;

    public Text Pause;
    public GameObject SpawnButton;
    public GameObject DateTime;

    private void Awake()
    {
        if (instence == null)
        {
            instence = this;
        }
    }
    public void Start()
    {
        playerSpawned = false;
    }
    private void Update()
    {
        DateTime.name = System.DateTime.Now.ToString();
    }
    void FixedUpdate()
    {
        if (!playerSpawned) {
            if (Input.GetButton("Submit"))
            {
                SpawnPlayer();
            }
        }
        if (Input.GetButton("Pause") && !isPausing)
        {
            Invoke("PauseGame", 0.2f);
            isPausing = true;
        }

    }

    public void SpawnPlayer()
    {
        Instantiate(Cube, positions.instence.points[0].position, positions.instence.points[0].rotation);
        playerSpawned = true;
        SpawnButton.SetActive(false);
    }
    public void PauseGame()
    {
        if (isPause)
        {
            isPause = false;
            Pause.text = "Pause";
        }
        else
        {
            isPause = true;
            Pause.text = "unPause";
        }
        isPausing = false;
    } 
}
