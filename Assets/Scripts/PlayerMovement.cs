using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    float xInput, yInput;
    public float increase = 0.0001f;
    public GameObject[] platforms;
    public GameObject spawnPoint, panel, scoreTotal, scorePlatforms;
    public AudioSource src;
    public AudioClip Death1, Death2, Explode, Quack;
    private bool landed;
    public TMP_Text deathScore;
    public static bool isAlive = true;

    private float spawnHeight = 0;

    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
        //Spawns 300 platforms below player using an array to randomize which platform spawns
        if (SceneManager.GetActiveScene().name.Equals("Dropping")) {
            for (int i=0; i<300; i++) {
                spawnHeight -= 5.5f;
                Vector3 temp = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y+spawnHeight, spawnPoint.transform.position.z);
                Instantiate(platforms[Random.Range(0, platforms.Length-1)], temp, Quaternion.identity);
            }
        }
    }
    //Sound for passing object and resets player landing
    public void BoomSFX() {
        landed = false;
        src.clip = Explode; 
        src.volume = 0.5f;   
        src.Play();
    }

    void FixedUpdate()
    {

        if(!landed && rb.velocity.y >= 0) {
            //Plays quacking noise whenever player lands
            landed = true;
            src.clip = Quack;
            src.Play();
        }
        //Allows for playermovement and sets velocity to 0 if player stops moving
        if (Input.GetAxis("Horizontal") != 0) {
            xInput = Input.GetAxis("Horizontal");

            transform.Translate(xInput*moveSpeed, yInput*moveSpeed,0);
        } else {
            rb.velocity = new Vector3(0f, rb.velocity.y, 0f);
        }
        //reset button for testing purposes
        // if (Input.GetKeyDown("r")) {
        //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // }
        Platform_Movement.ySpeed += increase;
        Flip();
    }
    //Flips player sprite if moving in opposite direction
    public void Flip() {
        if (Input.GetAxis("Horizontal") > 0) {
            transform.localScale = new Vector3(-0.3f,.3f,0);
        } else if (Input.GetAxis("Horizontal") < 0) {
            transform.localScale = new Vector3(0.3f,0.3f,0);
        }
    }       


    //Checks for player collision to top of screen to end game
    private void OnTriggerEnter2D(Collider2D c) {
        if (c.gameObject.tag.Equals("badgoi"))
        {
            Debug.Log("YOU DIED");
            isAlive = false;
            StartCoroutine("DeathSound");
        }
    }

    IEnumerator DeathSound(){
        //Plays a noise for player dying
        int temp= Random.Range(1,6);
        if(temp<5)
            src.clip = Death1;
        else
            src.clip = Death2;  
            
        src.Play();
        scoreTotal.SetActive(false);
        scorePlatforms.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        //Changes text to give player score
        if(SceneManager.GetActiveScene().name.Equals("Dropping")){
            deathScore.text="Score: " + Score.value.ToString() + "\n Platforms Passed: " + Score.platformsPassed.ToString();       
        } 
        if(SceneManager.GetActiveScene().name.Equals("Dodging")){
            deathScore.text="Score: " + Score.value.ToString() + "\n # of Objects Dodged: " + Score.platformsPassed.ToString();       
        }           
        //opens Game Over SCreen and removes player object
        panel.SetActive(true);
        gameObject.SetActive(false);


    }
}
