using System.Numerics;
using System.Reflection;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WormControler : MonoBehaviour
{
    // D (Declare Variable) A (Assign Value) R (Refer to other Code) E (Evaluate Condition)

    //Schritt für Schritt
    //access modifier public oder private
    //deklarieren der Klasse
    //MonoBehavior ist Überklasse; wir machen Unterklasse davon und können FUnktionen aus dieser Bibliothek hinzufügen.

    public float bulletForce = 350f;
    public Rigidbody RigidbodyWorm;
    public GameObject projectile;

    public GameObject Bazooka;
    public GameObject BulletSpawn;
    public int health = 10;

    public Text HealthText;
    public KeyCode jumpUP;
    public KeyCode left;
    public KeyCode right;
    public KeyCode shoot;

    public UnityEngine.Vector3 jumpForce;
    public UnityEngine.Vector3 moveForce;

    // Start is called before the first frame update
    void Start()
    {
        HealthText.text = health.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            Debug.Log("Left!");
            RigidbodyWorm.AddForce(-moveForce);
        }


        if (Input.GetKey(right))
        {
            Debug.Log("Right!");
            RigidbodyWorm.AddForce(moveForce);
        }


        if (Input.GetKeyDown(jumpUP))
        {
            Debug.Log("Jump!");
            RigidbodyWorm.AddForce(jumpForce);
        }


        if (Input.GetKeyDown(shoot))
        {
            Debug.Log("Shoot!");
            StartCoroutine(bulletLife());
        }

        /* if (health == 0f)
         {
             SceneManager.LoadScene("MainScene");
         }*/
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Projectile")
        {
            health = health - 1;
            Debug.Log("collision with Projectile");
            HealthText.text = health.ToString();
        }
        else if (collision.gameObject.tag == "HealthPack")
        {
            health = health + 2;
            Debug.Log("Healthpack!");
            HealthText.text = health.ToString();
            Destroy(collision.gameObject);
        }
        else
        {
            Debug.Log("no Kcllisison with anything");
            HealthText.text = health.ToString();
        }
    }

    IEnumerator bulletLife()
    {
        GameObject clone = Instantiate(projectile, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
        Rigidbody rigid = clone.GetComponent<Rigidbody>();
        rigid.AddForce(Bazooka.transform.up * bulletForce);
        yield return new WaitForSeconds(2);
        Destroy(clone);

    }
}


//not used

//public object Worm;
//public int x = 1;
/* public float speed = 10f;

 public float jump = 200f;*/
/* public Rigidbody Rigidbody_WormA;
 public Rigidbody Rigidbody_WormB;*/
// public GameObject Rigidbody_Bullet;

//public GameObject projectileB;

//public GameObject BazookaB;

//public GameObject BulletSpawnB;

//public int healthA = 10;
//public int healthB = 10;

//public Text HealthBText;

/* Rigidbody_WormA = GetComponent<Rigidbody>();
        Rigidbody_WormB = GetComponent<Rigidbody>();*/

//HealthBText.text = healthB.ToString();

/* if (collision.gameObject.tag == "Projectile")
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
             Destroy(collision.gameObject);
         }
         else
         {
             Debug.Log("no Kollisison with Healthpack");
         }*/

/* if (Input.GetKeyDown(KeyCode.Space))
         {
             Debug.Log("Space ist gedrückt!");
             GameObject clone = Instantiate(projectileA, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
             Rigidbody proA = clone.GetComponent<Rigidbody>();
             proA.AddForce(Bazooka.transform.up * bulletForce);
         }*/

//[SerializeField] private GameObject ABulletSpawn;
//[SerializeField] private GameObject ABazooka;

/*GameObject clone = Instantiate(projectile, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
        Rigidbody rbProjectile = clone.GetComponent<Rigidbody>();
        rbProjectile.AddForce(Bazooka.transform.up * 400f);*/

//clone.velocity = transform.TransformDirection(Vector3.forward * 10);
// Instantiate(projectile, new Vector3(0, 0, 0), Quaternion.identity);