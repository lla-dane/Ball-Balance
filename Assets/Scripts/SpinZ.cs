using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinZ : MonoBehaviour
{
    public float RotateSpeed;
    void Update()
    {
        Debug.Log("in");
        transform.Rotate(0f, 0f, RotateSpeed, Space.Self);
    }

   


}
