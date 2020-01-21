using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormControler : MonoBehaviour
{
    // D (Declare Variable) A (Assign Value) R (Refer to other Code) E (Evaluate Condition)

    public int x;
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        if (x > 0)
        {
            Debug.Log("x ist größer als 0");
        }
        else
        {
            Debug.Log("x ist 0 oder kleiner als 0");
        }

        if (text == "MaraJust")
        {
            Debug.Log("In der text variable steht MaraJust");
        }
        else
        {
            Debug.Log("In der text variable steht etwas anderes");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
