using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script is following a Score System tutorial on Youtube by Jimmy Vegas. 
//The star model is a free asset from Unity Asset Store. 

public class MoonNumber : MonoBehaviour
{
    public GameObject scoreText;  //to store the text displaying on screen
    public static int crumbsRemained;          //store the number of the stars collected
     //public int totalThrows;

    //When player collide with the star, the score will plus one. 
    void Update()
    {
        //theScore += 1;
        scoreText.GetComponent<Text>().text = "" + crumbsRemained;
        // Destroy(gameObject);
    }
}
