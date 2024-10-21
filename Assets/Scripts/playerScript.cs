using System.Collections;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    // Player Movement
    public float movementSpeed;
    public bool allowPlayerControl = true;

    // Player Weapons
    public GameObject laserBullet;
    private float nextShot = 0f;
    [SerializeField] private float fireDelay = 0.5f;
    [SerializeField] private bool allowShooting = true;

    // Player Health
    public int playerHP;
    public int playerMaxHP = 2;
    public int playerHealth;
    public int playerMaxHealth;
    public int playerExtraLives;

    // Respawning
    [SerializeField] private float respawnDelay;
    [SerializeField] private float invulnerableTime;

    public Sprite defaultSprite; 
    public Sprite damagedSprite;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        // Teleports player to start position
        transform.position = new Vector3(0, -3, 0);

        // Sets the player's health to max health
        playerHP = playerMaxHP;
        playerHealth = playerMaxHealth;

        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = defaultSprite;
    }

    private void Update()
    {
        // Allows horizontal movement
        float inputX = Input.GetAxis("Horizontal");
        if (allowPlayerControl)
        {
            transform.Translate(Vector3.right * movementSpeed * inputX * Time.deltaTime);
        }

        // Allows vertical movement
        float inputY = Input.GetAxis("Vertical");
        if (allowPlayerControl)
        {
            transform.Translate(Vector3.up * movementSpeed * inputY * Time.deltaTime);
        }

        // Wrap around effect
        if (transform.position.x >= 6.8)
        {
            transform.position = new Vector3(-6.79f, transform.position.y, 0);
        }
        if (transform.position.x <= -6.8)
        {
            transform.position = new Vector3(6.79f, transform.position.y, 0);
        }

        // Player shooting
        if (Input.GetKey(KeyCode.Space) && Time.time > nextShot && allowShooting == true)
        {
            Instantiate(laserBullet, transform.position, Quaternion.identity);
            nextShot = Time.time + fireDelay;
        }
    }

    // Let's the player lose health
    public void takeDamage(int damage)
    {
            playerHP -= damage;

        if (playerHP == 1)
        {
            spriteRenderer.sprite = damagedSprite; // Change to the damaged sprite
        }
        else
        {
            spriteRenderer.sprite = defaultSprite; // Change back to the normal sprite
        }

        if (playerHP <= 0) 
        {
            playerHealth -= damage;
            // Start the respawn process
            StartCoroutine(Respawn());
            playerHP = playerMaxHP;
        }

        // Check for player health
        if (playerHealth <= 0)
        {
            playerExtraLives--;
            if (playerExtraLives <= 0)
            {
                // GAME OVER SCREEN!
            }
            else
            {
                // Reset level from the start
            }
        }
    }

    private IEnumerator Respawn()
    {
        // Disable player control, hitbox, and sprite
        allowPlayerControl = false;
        allowShooting = false;
        GetComponent<Renderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;

        // Wait for 2 seconds
        yield return new WaitForSeconds(2f);

        // Teleport player to the bottom of the screen and reenables the sprite
        Vector3 startPosition = new Vector3(0, -5, 0);
        transform.position = startPosition;
        GetComponent<Renderer>().enabled = true;


        // Move player upwards to the start position
        float elapsedTime = 0f;
        Vector3 targetPosition = new Vector3(0, -3, 0); 

        while (elapsedTime < 1f)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime);
            elapsedTime += Time.deltaTime;
            // Enable player control
            allowPlayerControl = true;
            yield return null;
        }

        // Ensure final position is set
        transform.position = targetPosition;

        // Reenable hitbox and ability to shoot after a few seconds
        yield return new WaitForSeconds(invulnerableTime);
        allowShooting = true;
        GetComponent<BoxCollider2D>().enabled = true;
    }
}
