﻿
/*using UnityEngine;
using System.Collections;

public class OmniTurretScript : MonoBehaviour
{

    public GameObject bullet;
    public GameObject shotSpawn;
    public float shotDelay;
    public float repeatRate;
    public float shotSpeed;
    public Renderer playerRend;
    private bool blocked;
    private bool nesw; // determines if it is time to first North East South and West or not

    void Start()
    {
        InvokeRepeating("LaunchProjectile", shotDelay, repeatRate);

    }

    void Update()
    {
        /*
        RaycastHit2D hit = Physics2D.Linecast(transform.position, Player.transform.position);
        
        if (hit.collider.tag == "Wall")
        {
            Debug.Log("blocked");
            blocked = true;

        }
        else
        {
            Debug.Log("Not Blocked");
            blocked = false;
        }
        //transform.LookAt(Player.transform); // can be used to rotate the enemy to face the player, doesn't work for 2D too well atm
        

    }

    void LaunchProjectile()
    {
        if (nesw)
        {
            for (int i = 0; i <= 3; i++)
            GameObject instance = Instantiate(bullet, shotSpawn.transform.position, shotSpawn.transform.rotation) as GameObject;
            float angle = Mathf.Atan2(Player.transform.position.y - transform.position.y,
                                       Player.transform.position.x - transform.position.x);
            Rigidbody2D rb2 = instance.GetComponent<Rigidbody2D>(); // rb2 is for the bullets
            rb2.velocity = new Vector2(Mathf.Cos(angle) * shotSpeed, Mathf.Sin(angle) * shotSpeed);
        }
    }
}
*/
