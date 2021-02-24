using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [Header("Dropper Behavior")]
    [SerializeField] [Range(1f, 15f)] float waitTime = 3f;

    MeshRenderer renderer;
    Rigidbody rb;

    void Start(){
      renderer = GetComponent<MeshRenderer>();
      rb = GetComponent<Rigidbody>();

      renderer.enabled = false;
      rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {

      if(Time.time >= waitTime){
        rb.useGravity = true;
        renderer.enabled = true;
      }
      Debug.Log("time passed: " + Time.time);

    }
}
