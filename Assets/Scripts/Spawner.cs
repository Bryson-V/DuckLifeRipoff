using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float bounds = 9f;
    public GameObject[] Obstacles;
    public GameObject Warning;
    public float spawnSpeed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        //sets player to alive and starts routine
        PlayerMovement.isAlive=true;
        StartCoroutine("SpawnObstacles");
    }

    IEnumerator SpawnObstacles() {
        //After a certain amount of time, calls for a spawn of an object
        while (PlayerMovement.isAlive) {
            yield return new WaitForSeconds(spawnSpeed);
            StartCoroutine("SpawnWarning");
        }
    }
    //Spawns warning triangle, then waits until object is spawned, and disappears
    IEnumerator SpawnWarning() {
        transform.position = new Vector3(Random.Range(-bounds,bounds), transform.position.y, 0);
        Vector3 temp = transform.position;
        GameObject temp1 = Instantiate(Warning, new Vector3(transform.position.x, transform.position.y-1.5f, 0), Quaternion.identity);
        yield return new WaitForSeconds(1.6f);
        Instantiate(Obstacles[Random.Range(0,5)], temp, Quaternion.identity);
        yield return new WaitForSeconds(.5f);
        Destroy(temp1);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //Constantly increases how fast objects spawn
        spawnSpeed -= 0.0001f;
    }
}
