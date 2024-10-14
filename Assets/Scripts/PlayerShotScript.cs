using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotScript : MonoBehaviour
{
    public float shotSpeed;
    public float shotTime;

    void FixedUpdate()
    {
        shotTime = shotTime - 1;
        if (shotTime <= 0 || this.transform.position.y > 5)
        {
            Destroy(this.gameObject);
        }

        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + shotSpeed, this.transform.position.z);
    }
}