using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{
  
    private void OnTriggerEnter2D(Collider collision)
    {
        Destroy(collision.gameObject);
    }
    
}
