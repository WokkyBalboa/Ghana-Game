using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    private Rigidbody2D rigid;
    [SerializeField] public float jumpForce = 6.0f;
	[SerializeField] private float force = 8.0f;
	[SerializeField] public float gravity = -0.8f;
    public bool grounded = false;
    private int i;
    private int delay = 2;

    public GameObject levelComplete;
    public GameObject StartPos;
    public GameObject SpritePowerUp;
    public HealthBar healthbar;
    public string restart = "SampleScene";
    public int tutorial;
    public int coins;
    public int lives = 4;
    public int EnemiesAmount;
    public int EnemiesKilled;
    public float dead = 0f;
    public float knockback = 2;
    public float knockbackCount;
    public int invulTime = 3;
    public bool invulnerable = false;
    public bool knockFromRight;
    public bool audioSFX = false;
    public int powerUp;
    public Sprite normSprite;
    public Sprite hurtSprite;
    public AudioSource source;
    public AudioClip jumpSFX;
    

    // Use this for initialization
    void Start() {
        powerUp = CoinKeeper.Powerups;
        rigid = GetComponent<Rigidbody2D>();
        StartPos = GameObject.Find("PlayerStart");
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        powerUp = CoinKeeper.Powerups;
        Movement();
        Jump();
        deadCheck();
        PoweredUp();
    }

	bool CheckInputJump()
	{
		return (Input.touchCount > 0) || Input.GetButton("Jump");
	}

    //jump if grounded is true
    void Jump()
    {

        if (CheckInputJump() && grounded == true)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, jumpForce);
            grounded = false;
            StartCoroutine(play());
                
            
        }

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.down, 1.0f, 1 << 8);

        //Debug.DrawRay(transform.position, Vector2.down, Color.green);

        if (hitInfo.collider != null)
        {
            grounded = true;
         
        }
    }

    IEnumerator play()
    {
      source.PlayOneShot(jumpSFX);
        yield return new WaitForSeconds(delay);
    }
    
     

	float GetInputAcceleration()
	{
		var debugAx = Input.GetAxis("Horizontal");
		if (!Mathf.Approximately(debugAx, 0f))
			return debugAx;
		return Input.acceleration.x;
	}

    void Movement()
    {
        if (knockbackCount <= 0)
        {
            Vector2 dir = new Vector2(GetInputAcceleration(), gravity);
            Physics2D.gravity = dir * force;
        }
        else
        {
            if (knockFromRight)
            {
                rigid.velocity = new Vector2(-knockback, knockback);
            }
            if (!knockFromRight)
            {
                rigid.velocity = new Vector2(knockback, knockback);
            }
            knockbackCount -= Time.deltaTime;
        }

        
    }

    

    void OnCollisionEnter2D(Collision2D col)
    {
        //on collision with an "launchpad object" launch player in the air
        for (i = 0; i < 10; i++)
        {
            if (col.gameObject.name == "launchPad" + i)
            {
                rigid.velocity = new Vector2(rigid.velocity.x, jumpForce * 3);
            }

       
        }
        i = 0;

        //on collision while lives aren't 0 with a Hazards_Tilemap respawn at start.
        if (col.gameObject.name == "Hazards_Tilemap")
        {
            lives--;
            transform.position = StartPos.transform.position;
        }
        

        //on collision while lives are 0 with a Hazards_Tilemap reset map
       

        //reached end, restart map
        if (col.gameObject.name == "PlayerEnd")
        {
            levelComplete.SetActive(true);
        }

    }

    void deadCheck()
    {
        if(healthbar.healthOld <= dead)
        {
            SceneManager.LoadScene(restart);
        }
    }

    void PoweredUp()
    {
        if(CoinKeeper.Powerups > 0)
        {
            SpritePowerUp.SetActive(true);
        }
        else
        {
            SpritePowerUp.SetActive(false);
        }

    }

   

}
