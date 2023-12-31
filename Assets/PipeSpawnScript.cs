using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    private float spawnRate = 3.5F;
    private float timer = 0;
    public float heightOffset = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(spawnRate);
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;  // transform.position returns position value for the object of this script (pipespawner object)
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0),  transform.rotation);
        // 2nd argument is a object vector 3 with same x position as spawner but random y in a range, z = 0 , same rotation as spawner
    }
}
