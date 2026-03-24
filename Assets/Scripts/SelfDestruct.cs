using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    [SerializeField] float timeToDestruct = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeToDestruct); // destroy the game object after 3 seconds
    }

    // Update is called once per frame
 
    
}
