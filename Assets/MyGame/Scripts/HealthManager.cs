using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int health = 10;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            health = health - 1;
            Debug.Log("Kollision Projectile");
        }
        else
        {
            Debug.Log("Andere Kollision");
        }

        if (collision.gameObject.tag == "HealthPack")
        {
            health = health + 2;
            Debug.Log("Healthpack!");
        }
        else
        {
            Debug.Log("no Kollisison with Healthpack");
        }

    }

}
