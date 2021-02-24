using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] [Range(0.1f,5f)] float spinSpeedX = 0f;
    [SerializeField] [Range(0.1f,5f)] float spinSpeedY = 1f;
    [SerializeField] [Range(0.1f,5f)] float spinSpeedZ = 0f;

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(spinSpeedX, spinSpeedY, spinSpeedZ);

    }
}
