using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormControler : MonoBehaviour
{
    // D (Declare Variable) A (Assign Value) R (Refer to other Code) E (Evaluate Condition)

    //Schritt für Schritt
    //access modifier public oder private
    //deklarieren der Klasse
    //MonoBehavior ist Überklasse; wir machen Unterklasse davon und können FUnktionen aus dieser Bibliothek hinzufügen.
    //

    //public object Worm;
    public int x = 1;
    public float speed = 10f;
    public float bulletForce = 350f;
    public Rigidbody Rigidbody_Worm;
    public GameObject projectile;
    public GameObject Rigidbody_Bullet;
    public GameObject Bazooka;
    public GameObject BulletSpawn;

    //[SerializeField] private GameObject ABulletSpawn;
    //[SerializeField] private GameObject ABazooka;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody_Worm = GetComponent<Rigidbody>();
        //Rigidbody_Bullet = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {

            Debug.Log("E ist gedrückt!");
            Rigidbody_Worm.AddForce(transform.right * speed);


        }


        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Q ist gedrückt!");
            Rigidbody_Worm.AddForce(-transform.right * speed);

        }


        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W ist gedrückt!");
            Rigidbody_Worm.AddForce(transform.up * speed);

        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space ist gedrückt!");
            // Instantiate(projectile, new Vector3(0, 0, 0), Quaternion.identity);
            GameObject clone = Instantiate(projectile, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
            Rigidbody pro = clone.GetComponent<Rigidbody>();
            //clone.velocity = transform.TransformDirection(Vector3.forward * 10);
            pro.AddForce(Bazooka.transform.up * bulletForce);

            /*GameObject clone = Instantiate(projectile, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
            Rigidbody rbProjectile = clone.GetComponent<Rigidbody>();
            rbProjectile.AddForce(Bazooka.transform.up * 400f);*/
        }
    }
}