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
    public Rigidbody Rigidbody_Worm;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody_Worm = GetComponent<Rigidbody>();
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
        }


    }
}
