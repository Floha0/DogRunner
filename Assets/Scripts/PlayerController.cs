using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject[] projectilePrefab;
    private float verticalInput;
    private float downBound = 0.35f;
    private float topBound = 7.5f;
    private bool canSpawn;
    void Start()
    {
        InvokeRepeating("controlSpawn", 0, 1f);
    }
    void Update()
    {
        // Movement
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);

        if (transform.position.y < downBound)
        {
            transform.position = new Vector3(transform.position.x, 0.35f, transform.position.z);
        } else if (transform.position.y > topBound){
            transform.position = new Vector3(transform.position.x, 7.5f, transform.position.z);
        }

        // Spawn projectile
        if (canSpawn)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0,projectilePrefab.Length);
                Vector3 projectileOffset = new Vector3(0f, 0.5f, 0f); 
                Instantiate(projectilePrefab[index], transform.position + projectileOffset , projectilePrefab[index].transform.rotation);
                canSpawn = false;
            }
        }

    }

    private void controlSpawn(){
        canSpawn = true;
    }

}
