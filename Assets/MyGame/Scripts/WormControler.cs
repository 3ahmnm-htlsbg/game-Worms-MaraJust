using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WormControler : MonoBehaviour
{
    // D (Declare Variable) A (Assign Value) R (Refer to other Code) E (Evaluate Condition)

    //Schritt für Schritt
    //access modifier public oder private
    //deklarieren der Klasse
    //MonoBehavior ist Überklasse; wir machen Unterklasse davon und können FUnktionen aus dieser Bibliothek hinzufügen.
    //

    //public object Worm;
    //public int x = 1;
    public float speed = 10f;
    public float bulletForce = 350f;
    public Rigidbody Rigidbody_WormA;
    public Rigidbody Rigidbody_WormB;
    public GameObject projectileA;
    public GameObject projectileB;
    // public GameObject Rigidbody_Bullet;
    public GameObject BazookaA;
    public GameObject BazookaB;
    public GameObject BulletSpawnA;
    public GameObject BulletSpawnB;

    public int healthA = 10;
    public int healthB = 10;

    public Text HealthAText;
    public Text HealthBText;




    // Start is called before the first frame update
    void Start()
    {
        Rigidbody_WormA = GetComponent<Rigidbody>();
        Rigidbody_WormB = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update()
    {

        if (Rigidbody_WormA == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("E ist gedrückt!");
                Rigidbody_WormA.AddForce(transform.right * speed);
            }


            if (Input.GetKey(KeyCode.Q))
            {
                Debug.Log("Q ist gedrückt!");
                Rigidbody_WormA.AddForce(-transform.right * speed);
            }


            if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("W ist gedrückt!");
                Rigidbody_WormA.AddForce(transform.up * speed);
            }


            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space ist gedrückt!");
                GameObject clone = Instantiate(projectileA, BulletSpawnA.transform.position, BulletSpawnA.transform.rotation);
                Rigidbody proA = clone.GetComponent<Rigidbody>();
                proA.AddForce(BazookaA.transform.up * bulletForce);
            }

        }

        if (Rigidbody_WormB == true)
        {

            if (Input.GetKey(KeyCode.I))
            {

                Debug.Log("O ist gedrückt!");
                Rigidbody_WormB.AddForce(-transform.right * speed);


            }


            if (Input.GetKey(KeyCode.P))
            {
                Debug.Log("P ist gedrückt!");
                Rigidbody_WormB.AddForce(transform.right * speed);

            }


            if (Input.GetKey(KeyCode.O))
            {
                Debug.Log("O ist gedrückt!");
                Rigidbody_WormB.AddForce(transform.up * speed);

            }


            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                Debug.Log("RightShift ist gedrückt!");
                GameObject clone = Instantiate(projectileB, BulletSpawnB.transform.position, BulletSpawnB.transform.rotation);
                Rigidbody proB = clone.GetComponent<Rigidbody>();
                proB.AddForce(BazookaB.transform.up * bulletForce);


            }
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (Rigidbody_WormA == true)
        {
            if (collision.gameObject.tag == "Projectile")
            {
                healthA = healthA - 1;
                Debug.Log("Kollision Projectile");
                HealthAText.text = healthA.ToString();
            }
            else
            {
                Debug.Log("Andere Kollision");
            }

            if (collision.gameObject.tag == "HealthPack")
            {
                healthA = healthA + 2;
                Debug.Log("Healthpack!");
                HealthAText.text = healthA.ToString();
            }
            else
            {
                Debug.Log("no Kollisison with Healthpack");
            }
        }
        if (Rigidbody_WormB == true)
        {
            if (collision.gameObject.tag == "Projectile")
            {
                healthB = healthB - 1;
                Debug.Log("Kollision Projectile");
                HealthBText.text = healthB.ToString();
            }
            else
            {
                Debug.Log("Andere Kollision");
            }

            if (collision.gameObject.tag == "HealthPack")
            {
                healthB = healthB + 2;
                Debug.Log("Healthpack!");
                HealthBText.text = healthB.ToString();
            }
            else
            {
                Debug.Log("no Kollisison with Healthpack");
            }
        }
    }


}


//not used

//[SerializeField] private GameObject ABulletSpawn;
//[SerializeField] private GameObject ABazooka;

/*GameObject clone = Instantiate(projectile, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
        Rigidbody rbProjectile = clone.GetComponent<Rigidbody>();
        rbProjectile.AddForce(Bazooka.transform.up * 400f);*/

//clone.velocity = transform.TransformDirection(Vector3.forward * 10);
// Instantiate(projectile, new Vector3(0, 0, 0), Quaternion.identity);