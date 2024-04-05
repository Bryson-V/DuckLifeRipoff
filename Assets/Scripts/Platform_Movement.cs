using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Movement : MonoBehaviour
{
    public static float ySpeed = 0.1f;
    private GameObject player;
    public GameObject Particles;
    public PlayerMovement pm;

    // Start is called before the first frame update
    void Start()
    {
        //Looks for player and Particles in scene.  Sets initial speed
        ySpeed=.05f;
        player = GameObject.Find("Player");
        pm = player.GetComponent<PlayerMovement>();
        Particles = GameObject.Find("Platform Particles");
    }

    // Update is called once per frame
    void Update()
    {
        //Checks for if platform has passed player and destroys object, creating an explosion effect.
        if (transform.position.y > player.transform.position.y-0.85f) {
            Score.platformsPassed++;
            Score.value += 100f; 
            Vector3 temp = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            if (Particles != null)
                Instantiate(Particles, temp, Quaternion.identity);
            pm.BoomSFX();
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        //Moves platform up at a certain rate.
        transform.Translate(Vector3.up * ySpeed * Time.fixedDeltaTime);
    }


}
