using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Plane_DE : MonoBehaviour
{
    public float movementSpeed = 1;
    public Rigidbody2D rb;
    float movement = 1;
    public bool direction = true;
    
    public GameObject spawncandy;
    public double timeToSpawn;
    private double curentTimeToSpawn;

    public GameObject spawnapple;
    public double timeToSpawnApple;
    private double curentTimeToSpawnApple;


    public void PlaneMovement()
    {
        if (direction == true)
        {
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 0, 0) : Quaternion.identity;
        }
        else
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * movementSpeed;
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
    }

    public void SpawnCandy()
    {
        Instantiate(spawncandy, transform.position,transform.rotation);
    }
    public void SpawnApple()
    {
        Instantiate(spawnapple, transform.position, transform.rotation);
    }

    private void Start()
    {


    }

    private void Update()
    {
        if (curentTimeToSpawn > 0)
        {
            curentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnCandy();
            curentTimeToSpawn = timeToSpawn;
        }
        if (curentTimeToSpawnApple > 0)
        {
            curentTimeToSpawnApple -= Time.deltaTime;
        }
        else
        {
            SpawnApple();
            curentTimeToSpawnApple = timeToSpawnApple;
        }
        Invoke("PlaneMovement", 0);
       
    }
}