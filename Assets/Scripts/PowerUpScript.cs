using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public float fallSpeed;

    void FixedUpdate()
    {
        if (this.transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }

        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - fallSpeed, this.transform.position.z);
    }
}
