using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float projectileSpeed;
    private float leftBound = -9.5f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * projectileSpeed);

        if (transform.position.z < leftBound){
            Destroy(gameObject);
        }

    }
}
