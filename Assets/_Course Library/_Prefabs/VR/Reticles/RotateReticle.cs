using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateReticle : MonoBehaviour
{
    public float rotationsPerMinute = 10.0f; 
    
    private void Update()
    {
        transform.Rotate(0, 6.0f * rotationsPerMinute * Time.deltaTime, 0);
    }
}
