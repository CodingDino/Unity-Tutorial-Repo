using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Editor variables
    [SerializeField]
    string editorString = "Adventure time!";

    // private variables
    string combinedString;

    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("You have my sword.");
        Debug.Log("And my bow.");
        Debug.Log("And my axe!");
        */

        // Declare a variable called firstString
        string firstString = "You shall not";
        string secondString = "PASS!";
        combinedString = firstString + " " + secondString;

        Debug.Log(combinedString);


        editorString = "Hello";
        Debug.Log(editorString);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update message!");
        //transform.Translate(0.5f, 0, 0);

        Debug.Log(combinedString);
    }
}
