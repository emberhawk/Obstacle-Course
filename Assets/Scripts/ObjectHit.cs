using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
      Debug.Log("You hit " + other.gameObject.name);
      GetComponent<MeshRenderer>().material.color = Color.red;
    }

}
