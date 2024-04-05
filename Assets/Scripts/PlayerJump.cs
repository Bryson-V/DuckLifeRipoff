using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerJump : MonoBehaviour{

    public float moveSpeed=0.1f;
    public float spawnHeight = 5f;
    private bool grounded = true;
    private GameObject groundCheck;
    private Rigidbody2D rb;
    public AudioSource src;
    public AudioClip Death1, Death2;
    public GameObject panel, scoreTotal, scorePlatforms, spawnPoint;
    public TMP_Text deathScore;
    public GameObject[] platforms;
    public float jumpHeight1 = 20f, jumpHeight2=25f, jumpHeight3=30f, jumpHeight4=35f, fallspeed = -20f; //? multiply keys 2 3 and 4 all by this same jump height
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Spawns 500 Obstacles and randomizes which one spawns from platforms[]
        for (int i=0; i<500; i++) {
            spawnHeight += 15;
            Vector3 temp = new Vector3(spawnPoint.transform.position.x+spawnHeight, spawnPoint.transform.position.y, spawnPoint.transform.position.z);
            Instantiate(platforms[Random.Range(0, platforms.Length)], temp, Quaternion.identity);
        }
        
    }

    void Update() 
    {
        //Takes in Keyboard inputs to determine how high the player Jumps.  Checks for multiple presses by restricting to one jump until ground is touched
        if (Input.GetKeyDown("1") && grounded) {
            grounded = false;
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight1, 0f); 
        }

        if (Input.GetKeyDown("2") && grounded) {
            grounded = false;
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight2, 0f); 
        }
        if (Input.GetKeyDown("3") && grounded) {
            grounded = false;
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight3, 0f); 
        }
        if (Input.GetKeyDown("4") && grounded) {
            grounded = false;
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight4, 0f); 
        }
        //Allows for the player to fall quickly using a Mouse button input
        if(Input.GetMouseButtonDown(0))
            rb.velocity = new Vector3(rb.velocity.x , fallspeed, 0f);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Constant Movement of Player
        transform.Translate(moveSpeed, 0,0);
    }
    private void OnTriggerEnter2D(Collider2D c) {
        //Trigger that is called when player runs into an obstacle
        if (c.gameObject.tag.Equals("badgoi"))
        {
            StartCoroutine("DeathSound");
        }
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        //Checks for if player is on ground
        if (c.gameObject.tag.Equals("ground"))
        {
            grounded=true;
        }
    }

    IEnumerator DeathSound(){
        
        int temp= Random.Range(1,6);
        //Deathsounds that can play on player death
        if(temp<5)
            src.clip = Death1;
        else
            src.clip = Death2;  
            
        src.Play();
        scoreTotal.SetActive(false);
        scorePlatforms.SetActive(false);
        //Gives Playerscore depending on which game was played 
        if(SceneManager.GetActiveScene().name.Equals("Dropping")){
            deathScore.text="Score: " + Score.value.ToString() + "\n Platforms Passed: " + Score.platformsPassed.ToString();       
        } 
        if(SceneManager.GetActiveScene().name.Equals("Dodging")){
            deathScore.text="Score: " + Score.value.ToString() + "\n # of Objects Dodged: " + Score.platformsPassed.ToString();       
        }         
        if(SceneManager.GetActiveScene().name.Equals("Jumping")){
            deathScore.text="Score: " + Score.value.ToString() + "\n # of Objects Passed: " + Score.platformsPassed.ToString();       
        }      
        //Game Over Screen appears and player object disappears
        panel.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        gameObject.SetActive(false);


    }
}

