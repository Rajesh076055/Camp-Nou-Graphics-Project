using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLight : MonoBehaviour
{
    
  
    private float RotX = 0.0f;
    // Update is called once per frame
    void Update()
    {
        RotX += 0.5f;
        transform.localEulerAngles = new Vector3(RotX, 0, 0);
        
    }
}
