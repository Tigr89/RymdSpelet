using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public float fallSpeed;
    int powerupType = 0;
    public Sprite powerupMovementSprite;
    public Sprite powerupCooldownSprite;

    private void Start()
    {
        powerupType = (int)(Mathf.Floor(Random.Range(1f, 2.99f)));

        if (powerupType == 1)
        {
            GetComponent<SpriteRenderer>().sprite = powerupMovementSprite;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = powerupCooldownSprite;
        }
    }

    void FixedUpdate()
    {
        if (this.transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }

        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - fallSpeed, this.transform.position.z);
    }

    public int GetPowerupType
    {
        get
        {
            return powerupType;
        }
    }
}
