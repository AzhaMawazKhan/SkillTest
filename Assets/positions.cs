using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positions : MonoBehaviour
{
    public static positions instence;
    public Transform[] points;
    private void Awake()
    {
        if(instence == null)
        {
            instence = this; 
        }
    }
}
