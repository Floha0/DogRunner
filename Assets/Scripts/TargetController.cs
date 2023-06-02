using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        // Destroy(other.gameObject);

         /* Doestn work
        if(other.gameObject == dogRef.gameObject){
            Debug.Log("Entered");
        }
        */
    }
}
