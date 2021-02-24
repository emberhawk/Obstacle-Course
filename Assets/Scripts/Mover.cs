using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Player Movement")]
    [SerializeField] [Range(0,1f)] float xValue = 0.01f;
    [SerializeField] [Range(0,1f)] float yValue = 0f;
    [SerializeField] [Range(0,1f)] float zValue = 0f;


    void Start()
    {


    }


    void Update()
    {
      transform.Translate(xValue, yValue, zValue);


    }
}
