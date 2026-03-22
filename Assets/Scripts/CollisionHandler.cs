using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log("triggered with " + other.gameObject.name);
    }

   private void OnCollisionEnter(Collision other) {
        Debug.Log("Collided with " + other.gameObject.name);
    }
}
