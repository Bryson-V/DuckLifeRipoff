using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassObject : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y < player.transform.position.y)
        {
            Score.platformsPassed++;
            Destroy(gameObject);
        }
    }
}
