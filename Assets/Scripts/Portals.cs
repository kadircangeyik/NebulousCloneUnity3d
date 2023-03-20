using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Portals : MonoBehaviour
{
    public GameObject bombfx;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")|| other.CompareTag("Fight"))
        {
            other.transform.position = new Vector2(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
        
        }
    }    
}
