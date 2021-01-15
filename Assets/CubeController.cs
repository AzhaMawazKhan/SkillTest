using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    int ToPoint;
    bool isMoving;
    private Vector3 velocity = Vector3.zero;
    public float SmoothTime = 1;
   

    private void Start()
    {
        isMoving = true;
        SceneController.instence.isPause = false;
        ToPoint = 1;
        incremental = true;
        SceneController.instence.isPausing = false;
    }
    void Update()
    {
        if (isMoving && !SceneController.instence.isPause)
        {
            this.transform.position = Vector3.SmoothDamp(transform.position,positions.instence.points[ToPoint].position , ref velocity, SmoothTime);
            if(Vector3.Distance(transform.position, positions.instence.points[ToPoint].position) < 0.1)
            {
                Invoke("SwitchToNext", 3);
                isMoving = false; 
            }
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetButton("Pause") && !SceneController.instence.isPausing)
        {
            Invoke("pauseMovement",0.2f);
            SceneController.instence.isPausing = true;
        }
    }
    bool incremental;
    public void SwitchToNext()
    {
        if (incremental)
        {
            if (ToPoint < 2)
            {
                ToPoint++;
            }
            else
            {
                incremental = false;
                SwitchToNext();
            }
        }
        else
        {
            if (ToPoint > 0)
            {
                ToPoint--;
            }
            else
            {
                incremental = true;
                SwitchToNext();
            }
        }
        isMoving = true;
    }
    
    public void pauseMovement()
    {
        SceneController.instence.PauseGame();
    } 
}
