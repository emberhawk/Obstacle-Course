using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [Header("Dropper Behavior")]
    [SerializeField] [Range(1f, 15f)] float waitTime = 3f;

    // Update is called once per frame
    void Update()
    {

      if(Time.time >= waitTime){
        gameObject.AddComponent<Rigidbody>();

      }

      Debug.Log("time passed: " + Time.time);

    }
}
