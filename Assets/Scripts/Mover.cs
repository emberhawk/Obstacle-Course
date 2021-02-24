using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Player Movement")]
    [SerializeField] [Range(0,1f)] float yValue = 0f;
    [SerializeField] [Range(1f, 20f)] float moveSpeed = 5f;

    void Start()
    {


    }


    void Update()
    {
      var delta = Time.deltaTime;

      float xValue = Input.GetAxis("Horizontal") * delta * moveSpeed;
      float zValue = Input.GetAxis("Vertical") * delta * moveSpeed;

      transform.Translate(xValue, yValue, zValue);


    }
}
