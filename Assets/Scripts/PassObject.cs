using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassObject : MonoBehaviour
{
    private GameObject player;
    private bool AMIDEAD = false;
    void Start()
    {
        //Checks objects in scene to find player
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Checks for if platform passes player and calls method to despawn
        if (player != null) {
            if(!AMIDEAD && transform.position.y < player.transform.position.y && SceneManager.GetActiveScene().name.Equals("Dodging"))
            {
                AMIDEAD = true;
                Score.platformsPassed++;
                StartCoroutine("DieASlowDeath");
            }
            if(!AMIDEAD && transform.position.x < player.transform.position.x && SceneManager.GetActiveScene().name.Equals("Jumping"))
            {
                AMIDEAD = true;
                Score.platformsPassed++;
                StartCoroutine("DieASlowDeath");
            }
        }
    }

    private IEnumerator DieASlowDeath() {
        //Destroys Gameobject after a certain amount of time has passed.
        yield return new WaitForSecondsRealtime(3f);
        Destroy(gameObject);

    }
}
