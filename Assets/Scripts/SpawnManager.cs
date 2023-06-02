using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject target;
    private float leftBorder = -8f;
    private float rightBorder = 3.5f;
    void Start()
    {
    InvokeRepeating("spawnTarget", 1.5f, Random.Range(3f,5f));
    }
    
    private void spawnTarget()
    {
        Instantiate(target, new Vector3(-5.5f, 11, Random.Range(leftBorder, rightBorder)), target.transform.rotation);
    }
}
