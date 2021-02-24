using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
      //Debug.Log("Wall hit " + other.gameObject.name);
      if(other.gameObject.name == "Player (Dodgy)"){
        GetComponent<MeshRenderer>().material.color = Color.red;
      }

    }

}
